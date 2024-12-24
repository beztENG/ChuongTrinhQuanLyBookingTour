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
            }
            else if (_bookingInfo.BookingType == "Tour")
            {
                lblBookingType.Text = "Tour Booking";
                lblTourName.Text = $"Tour Name: {_bookingInfo.TourName}";
                lblStarting.Text = $"Starting Tour at {_bookingInfo.Starting}";
                lblDestination.Text = $"Tour Destination at {_bookingInfo.Destination}";
                lblStartingDate.Text = $"Starting Date: {_bookingInfo.StartingDate?.ToShortDateString()}";
                lblReturnDate.Text = $"Return Date: {_bookingInfo.ReturnDate?.ToShortDateString()}";
                lblPrice.Text = $"Price: {_bookingInfo.Price:C}";
            }

            lblPrice.Text = $"Price: {_bookingInfo.Price:C}";

            // Chặn người dùng nhập vào giá
            guna2TextBoxAmount.Text = _bookingInfo.Price.ToString("F2");
            guna2TextBoxAmount.Enabled = false;
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
                SqlTransaction transaction = null;
                SqlCommand bookingCmd = null;
                SqlCommand approvalCmd = null;
                int bookingID = 0;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();


                    if (_bookingInfo.BookingType == "Flight")
                    {
                        string airlineQuery = "SELECT AirlineID FROM Flights WHERE FlightID = @FlightID";
                        using (SqlCommand cmd = new SqlCommand(airlineQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@FlightID", _bookingInfo.FlightID);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                _bookingInfo.AirlineID = Convert.ToInt32(result);
                            }
                            else
                            {
                                throw new Exception("AirlineID not found for the given FlightID.");
                            }
                        }
                        string flightBookingQuery = @"
                        INSERT INTO FlightBookings (UserID, FlightID, BookingDate, PaymentStatus, Status) 
                        OUTPUT INSERTED.FlightBookingID 
                        VALUES (@UserID, @FlightID, @BookingDate, 'Paid', 'Pending Approval')";
                        bookingCmd = new SqlCommand(flightBookingQuery, conn, transaction);
                        bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                        bookingCmd.Parameters.AddWithValue("@FlightID", _bookingInfo.FlightID);
                        bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);

                        bookingID = (int)bookingCmd.ExecuteScalar();
                        MessageBox.Show($"AirlineID: {_bookingInfo.AirlineID}");


                        string getEmployeesQuery = "SELECT EmployeeID FROM AirlineEmployees WHERE AirlineID = @AirlineID";
                        SqlCommand getEmployeesCmd = new SqlCommand(getEmployeesQuery, conn, transaction);
                        getEmployeesCmd.Parameters.AddWithValue("@AirlineID", _bookingInfo.AirlineID);

                        using (SqlDataReader reader = getEmployeesCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string approvalQuery = @"
                                INSERT INTO FlightBookingApprovals (FlightBookingID, EmployeeID, AirlineID, ApprovalStatus, ApprovalDate)
                                VALUES (@FlightBookingID, @EmployeeID, @AirlineID, 'Pending Approval', NULL)";
                                approvalCmd = new SqlCommand(approvalQuery, conn, transaction);
                                approvalCmd.Parameters.AddWithValue("@FlightBookingID", bookingID);
                                approvalCmd.Parameters.AddWithValue("@EmployeeID", reader["EmployeeID"]);
                                approvalCmd.Parameters.AddWithValue("@AirlineID", _bookingInfo.AirlineID);
                                approvalCmd.ExecuteNonQuery();
                            }
                            reader.Close();
                        }
                    }
                    else if (_bookingInfo.BookingType == "Hotel")
                    {
                        // Lưu thông tin đặt phòng khách sạn
                        string hotelBookingQuery = @"
    INSERT INTO HotelBookings 
    (UserID, HotelID, RoomID, BookingDate, CheckInDate, PaymentStatus, Status) 
    OUTPUT INSERTED.BookingID 
    VALUES (@UserID, @HotelID, @RoomID, @BookingDate, @CheckInDate, 'Paid', 'Pending Approval')";
                        bookingCmd = new SqlCommand(hotelBookingQuery, conn, transaction);
                        bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                        bookingCmd.Parameters.AddWithValue("@HotelID", _bookingInfo.HotelID);
                        bookingCmd.Parameters.AddWithValue("@RoomID", _bookingInfo.RoomID);
                        bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                        bookingCmd.Parameters.AddWithValue("@CheckInDate", _bookingInfo.CheckInDate);

                        bookingID = (int)bookingCmd.ExecuteScalar();

                        // Tìm danh sách nhân viên liên quan đến HotelID
                        string getHotelEmployeesQuery = "SELECT EmployeeID FROM HotelEmployees WHERE HotelID = @HotelID";
                        SqlCommand getHotelEmployeesCmd = new SqlCommand(getHotelEmployeesQuery, conn, transaction);
                        getHotelEmployeesCmd.Parameters.AddWithValue("@HotelID", _bookingInfo.HotelID);

                        using (SqlDataReader reader = getHotelEmployeesCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string approvalQuery = @"
            INSERT INTO HotelBookingApprovals (BookingID, EmployeeID, HotelID, ApprovalStatus, ApprovalDate)
            VALUES (@BookingID, @EmployeeID, @HotelID, 'Pending Approval', NULL)";
                                approvalCmd = new SqlCommand(approvalQuery, conn, transaction);
                                approvalCmd.Parameters.AddWithValue("@BookingID", bookingID);
                                approvalCmd.Parameters.AddWithValue("@EmployeeID", reader["EmployeeID"]);
                                approvalCmd.Parameters.AddWithValue("@HotelID", _bookingInfo.HotelID);
                                approvalCmd.ExecuteNonQuery();
                            }
                            reader.Close();
                        }
                    }
                    else if (_bookingInfo.BookingType == "Tour")
                    {
                        // Lưu thông tin đặt tour
                        string tourBookingQuery = @"
    INSERT INTO TourBookings 
    (UserID, TourID, BookingDate, PaymentStatus) 
    OUTPUT INSERTED.TourBookingID 
    VALUES (@UserID, @TourID, @BookingDate, 'Paid')";
                        bookingCmd = new SqlCommand(tourBookingQuery, conn, transaction);
                        bookingCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                        bookingCmd.Parameters.AddWithValue("@TourID", _bookingInfo.TourID);
                        bookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);

                        bookingID = (int)bookingCmd.ExecuteScalar();

                        // Tìm danh sách nhân viên liên quan đến TourID
                        string getTourEmployeesQuery = "SELECT EmployeeID FROM TourEmployees WHERE TourID = @TourID";
                        SqlCommand getTourEmployeesCmd = new SqlCommand(getTourEmployeesQuery, conn, transaction);
                        getTourEmployeesCmd.Parameters.AddWithValue("@TourID", _bookingInfo.TourID);

                        using (SqlDataReader reader = getTourEmployeesCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string approvalQuery = @"
            INSERT INTO TourBookingApprovals (TourBookingID, EmployeeID, TourID, ApprovalStatus, ApprovalDate)
            VALUES (@TourBookingID, @EmployeeID, @TourID, 'Pending Approval', NULL)";
                                approvalCmd = new SqlCommand(approvalQuery, conn, transaction);
                                approvalCmd.Parameters.AddWithValue("@TourBookingID", bookingID);
                                approvalCmd.Parameters.AddWithValue("@EmployeeID", reader["EmployeeID"]);
                                approvalCmd.Parameters.AddWithValue("@TourID", _bookingInfo.TourID);
                                approvalCmd.ExecuteNonQuery();
                            }
                            reader.Close();
                        }
                    }


                    // 4. Lưu thông tin thanh toán vào bảng `Payments`
                    string paymentQuery = @"
            INSERT INTO Payments 
            (UserID, Amount, PaymentMethod, BookingID, BookingType) 
            VALUES (@UserID, @Amount, @PaymentMethod, @BookingID, @BookingType)";
                    SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction);
                    paymentCmd.Parameters.AddWithValue("@UserID", _bookingInfo.UserID);
                    paymentCmd.Parameters.AddWithValue("@Amount", amount);
                    paymentCmd.Parameters.AddWithValue("@PaymentMethod", selectedPaymentMethod);
                    paymentCmd.Parameters.AddWithValue("@BookingID", bookingID);
                    paymentCmd.Parameters.AddWithValue("@BookingType", _bookingInfo.BookingType);

                    paymentCmd.ExecuteNonQuery();

                    // Commit giao dịch nếu tất cả thành công
                    transaction.Commit();

                    MessageBox.Show("Payment submitted and booking saved successfully!");
                    this.DialogResult = DialogResult.OK;  // Đặt kết quả của form là OK
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback giao dịch
                    if (transaction != null)
                    {
                        transaction?.Rollback();
                    }
                    MessageBox.Show($"Error during booking and payment: {ex.Message}");
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
