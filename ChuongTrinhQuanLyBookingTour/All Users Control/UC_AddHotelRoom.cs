﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers; 

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    public partial class UC_AddHotelRoom : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_AddHotelRoom()
        {
            InitializeComponent();
            LoadHotels(); 
        }

        private void LoadHotels()
        {
            string query = "SELECT HotelID, HotelName FROM Hotels";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtHotel.DataSource = dt;
                txtHotel.DisplayMember = "HotelName";
                txtHotel.ValueMember = "HotelID";
            }
        }

        private void txtHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtHotel.SelectedValue is DataRowView)
                return;

            int selectedHotelID = (int)txtHotel.SelectedValue;
            DisplayHotelImage(selectedHotelID);
            LoadRoomDetails(selectedHotelID);
        }

        private void DisplayHotelImage(int hotelID)
        {
            string query = "SELECT HotelImage FROM Hotels WHERE HotelID = @HotelID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HotelID", hotelID);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string imageName = result.ToString();
                    string imagePath = Path.Combine(Application.StartupPath, @"Images\Hotel", imageName);

                    if (File.Exists(imagePath))
                    {
                        if (pictureBoxHotelImage.Image != null)
                        {
                            pictureBoxHotelImage.Image.Dispose();
                        }

                        Image originalImage = Image.FromFile(imagePath);
                        pictureBoxHotelImage.Image = ImageHelper.ResizeImage(originalImage, 600, 500);
                    }
                    else
                    {
                        pictureBoxHotelImage.Image = null;
                        MessageBox.Show($"Image file '{imageName}' not found.");
                    }
                }
                else
                {
                    pictureBoxHotelImage.Image = null;
                    MessageBox.Show("No image found for this hotel.");
                }
            }
        }

        private void LoadRoomDetails(int hotelID)
        {
            string query = "SELECT RoomID, RoomType, BedType, Price FROM Rooms WHERE HotelID = @HotelID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HotelID", hotelID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtRoomtype.DataSource = dt;
                txtPrice.DataSource = dt;
                txtBed.DataSource = dt;
                txtRoomtype.DisplayMember = "RoomType"; 
                txtRoomtype.ValueMember = "RoomID"; 
                txtBed.DisplayMember = "BedType";
                txtBed.ValueMember = "RoomID";
                txtPrice.DisplayMember = "txtPrice";
                txtPrice.ValueMember = "Price";
            }
        }


        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (txtHotel.SelectedValue == null || txtRoomtype.SelectedValue == null || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int selectedHotelID = (int)txtHotel.SelectedValue;
            int selectedRoomID = (int)txtRoomtype.SelectedValue;
            int userID = GlobalUserInfo.UserID;

            if (userID == 0)
            {
                MessageBox.Show("Invalid UserID. Please log in again.");
                return;
            }

            DateTime bookingDate = DateTime.Now;
            DateTime checkInDate = dateCheckInPicker.Value;

            if (checkInDate < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past.");
                return;
            }

            string query = "INSERT INTO HotelBookings (UserID, HotelID, RoomID, BookingDate, CheckInDate) " +
                           "VALUES (@UserID, @HotelID, @RoomID, @BookingDate, @CheckInDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@HotelID", selectedHotelID);
                cmd.Parameters.AddWithValue("@RoomID", selectedRoomID);
                cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hotel room booking added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while booking: {ex.Message}");
                }
            }
        }




        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}