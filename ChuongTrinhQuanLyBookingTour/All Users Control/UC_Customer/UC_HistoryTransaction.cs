﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    public partial class UC_HistoryTransaction : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_HistoryTransaction()
        {
            InitializeComponent();
            LoadBookingHistory(); 
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e); 
            if (this.Visible)
            {
                LoadBookingHistory(); 
            }
        }

        public void LoadBookingHistory()
        {
            string query = @"
            SELECT 'Hotel' AS BookingType, hb.BookingID, h.HotelName AS Name, hb.CheckInDate AS BookingDate, hb.Status
            FROM HotelBookings hb
            JOIN Hotels h ON hb.HotelID = h.HotelID
            WHERE hb.UserID = @UserID

            UNION

            SELECT 'Flight' AS BookingType, fb.FlightBookingID AS BookingID, f.Airline AS Name, f.DepartureDate AS BookingDate, fb.Status
            FROM FlightBookings fb
            JOIN Flights f ON fb.FlightID = f.FlightID
            WHERE fb.UserID = @UserID

            UNION

            SELECT 'Tour' AS BookingType, tb.TourBookingID AS BookingID, t.TourName AS Name, t.StartingDate AS BookingDate, tb.Status
            FROM TourBookings tb
            JOIN Tours t ON tb.TourID = t.TourID
            WHERE tb.UserID = @UserID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewHistory.DataSource = dt;
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.SelectedRows.Count > 0)
            {
                string bookingType = dataGridViewHistory.SelectedRows[0].Cells["BookingType"].Value.ToString();
                int bookingID = Convert.ToInt32(dataGridViewHistory.SelectedRows[0].Cells["BookingID"].Value);
                DateTime bookingDate = Convert.ToDateTime(dataGridViewHistory.SelectedRows[0].Cells["BookingDate"].Value);
                DateTime currentDate = DateTime.Now;

                if (bookingType == "Hotel" && (bookingDate - currentDate).TotalDays > 1)
                {
                    CancelBooking("HotelBookings", "BookingID", bookingID);
                }
                else if (bookingType == "Flight" && (bookingDate - currentDate).TotalDays > 4)
                {
                    CancelBooking("FlightBookings", "FlightBookingID", bookingID);
                }
                else if (bookingType == "Tour" && (bookingDate - currentDate).TotalDays > 7)
                {
                    CancelBooking("TourBookings", "TourBookingID", bookingID);
                }
                else
                {
                    MessageBox.Show("You cannot cancel this booking as it doesn't meet the cancellation criteria.");
                }
            }
        }

        private void CancelBooking(string tableName, string columnID, int bookingID)
        {
            string query = $"UPDATE {tableName} SET Status = 'Canceled' WHERE {columnID} = @BookingID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking canceled successfully.");
                LoadBookingHistory(); 
            }
        }
    }
}