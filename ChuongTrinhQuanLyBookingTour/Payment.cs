using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;
using ChuongTrinhQuanLyBookingTour.Models;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Payment : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private BookingInfo _bookingInfo;

        public Payment(BookingInfo bookingInfo)
        {
            InitializeComponent();
            _bookingInfo = bookingInfo;

            // Hiển thị thông tin phòng
            DisplayBookingInfo();
        }

        private void DisplayBookingInfo()
        {
            if (_bookingInfo.BookingType == "Flight")
            {
                lblBookingType.Text = "Flight Booking";
                lblAirline.Text = $"Airline: {_bookingInfo.Airline}";
                lblDepartureDate.Text = $"Departure Date: {_bookingInfo.DepartureDate?.ToShortDateString()}";
            }
            else if (_bookingInfo.BookingType == "Hotel")
            {
                lblBookingType.Text = "Hotel Booking";
                lblHotelID.Text = $"Hotel ID: {_bookingInfo.HotelID}";
                lblRoomID.Text = $"Room ID: {_bookingInfo.RoomID}";
                lblCheckInDate.Text = $"Check-in Date: {_bookingInfo.CheckInDate?.ToShortDateString()}";      
                
            }else if(_bookingInfo.BookingType == "Tour")
            {
                lblBookingType.Text = "Tour Booking";
                lblTourName.Text = $"Tour Name: {_bookingInfo.TourName}";
                lblStarting.Text = $"Starting Tour at{_bookingInfo.Starting}";
                lblDestination.Text = $"Tour Destination at{_bookingInfo.Destination}";
                lblStartingDate.Text = $"Starting Date: {_bookingInfo.StartingDate?.ToShortDateString()}";
                lblReturnDate.Text = $"Return Date: {_bookingInfo.ReturnDate?.ToShortDateString()}";
                lblPrice.Text = $"Price: {_bookingInfo.Price:C}";
            }

            lblPrice.Text = $"Price: {_bookingInfo.Price:C}";

            // Chặn người dùng nhập vào giá
            guna2TextBoxAmount.Text = _bookingInfo.Price.ToString("F2");
            guna2TextBoxAmount.Enabled = false; // Không cho phép nhập vào TextBox giá
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2ComboBoxPaymentMethod.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string selectedPaymentMethod = guna2ComboBoxPaymentMethod.SelectedItem.ToString();
            decimal amount = _bookingInfo.Price;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand bookingCmd = null;

                if (_bookingInfo.BookingType == "Flight")
                {
                    // Lưu thông tin đặt chuyến bay
                    string flightBookingQuery = "INSERT INTO FlightBookings (UserID, FlightID, BookingDate, PaymentStatus) OUTPUT INSERTED.FlightBookingID VALUES (@UserID, @FlightID, @BookingDate, 'Paid')";
                    bookingCmd = new SqlCommand(flightBookingQuery, conn);
                    bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                    bookingCmd.Parameters.AddWithValue("@FlightID", _bookingInfo.FlightID);
                    bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                }
                else if (_bookingInfo.BookingType == "Hotel")
                {
                    // Lưu thông tin đặt phòng khách sạn
                    string hotelBookingQuery = "INSERT INTO HotelBookings (UserID, HotelID, RoomID, BookingDate, CheckInDate, PaymentStatus) OUTPUT INSERTED.BookingID VALUES (@UserID, @HotelID, @RoomID, @BookingDate, @CheckInDate, 'Paid')";
                    bookingCmd = new SqlCommand(hotelBookingQuery, conn);
                    bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                    bookingCmd.Parameters.AddWithValue("@HotelID", _bookingInfo.HotelID);
                    bookingCmd.Parameters.AddWithValue("@RoomID", _bookingInfo.RoomID);
                    bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                    bookingCmd.Parameters.AddWithValue("@CheckInDate", _bookingInfo.CheckInDate);
                }
                else if (_bookingInfo.BookingType == "Tour")
                {
                    // Lưu thông tin đặt tour
                    string tourBookingQuery = "INSERT INTO TourBookings (UserID, TourID, BookingDate, PaymentStatus) OUTPUT INSERTED.TourBookingID VALUES (@UserID, @TourID, @BookingDate, 'Paid')";
                    bookingCmd = new SqlCommand(tourBookingQuery, conn);
                    bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                    bookingCmd.Parameters.AddWithValue("@TourID", _bookingInfo.TourID);
                    bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                }

                try
                {
                    conn.Open();
                    int bookingID = (int)bookingCmd.ExecuteScalar();

                    // Lưu thông tin thanh toán
                    string paymentQuery = "INSERT INTO Payments (UserID, Amount, PaymentMethod, BookingID, BookingType) VALUES (@UserID, @Amount, @PaymentMethod, @BookingID, @BookingType)";
                    SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn);

                    paymentCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                    paymentCmd.Parameters.AddWithValue("@Amount", amount);
                    paymentCmd.Parameters.AddWithValue("@PaymentMethod", selectedPaymentMethod);
                    paymentCmd.Parameters.AddWithValue("@BookingID", bookingID);
                    paymentCmd.Parameters.AddWithValue("@BookingType", _bookingInfo.BookingType);

                    paymentCmd.ExecuteNonQuery();

                    MessageBox.Show("Payment submitted and booking saved successfully!");
                    this.DialogResult = DialogResult.OK;  // Đặt kết quả của form là OK
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during booking and payment: {ex.Message}");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
