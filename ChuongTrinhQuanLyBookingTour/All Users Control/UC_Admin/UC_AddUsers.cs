using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class UC_AddUsers : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        public UC_AddUsers()
        {
            InitializeComponent();
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAssociation.Items.Clear();
            string query = "";
            // Logic to populate cmbAssociation based on selected role
            if (cmbRole.SelectedItem.ToString() == "HotelProvider")
            {
                query = "SELECT HotelName FROM Hotels";
            }
            else if (cmbRole.SelectedItem.ToString() == "AirlineProvider")
            {
                query = "SELECT AirlineName FROM Airlines";
            }
            else if (cmbRole.SelectedItem.ToString() == "CompanyTourProvider")
            {
                query = "SELECT TourName FROM Tours";
            }
            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cmbAssociation.Items.Add(reader[0].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();
            string associatedServiceName = cmbAssociation.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName) ||
       string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(role) ||
       string.IsNullOrEmpty(associatedServiceName))
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }

            // Thêm người dùng vào bảng Users
            string queryInsertUser = "INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role) " +
                                     "VALUES (@Username, @Password, @FullName, @Email, @Phone, @Avatar, @Role); " +
                                     "SELECT SCOPE_IDENTITY();"; // Lấy UserID của người dùng vừa thêm

            int userId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryInsertUser, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Nên mã hóa mật khẩu trước khi lưu
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Avatar", DBNull.Value);
                    command.Parameters.AddWithValue("@Role", role);

                    // Lấy UserID của người dùng vừa thêm
                    userId = Convert.ToInt32(command.ExecuteScalar());

                    // Xử lý theo từng vai trò (role)
                    if (role == "HotelProvider")
                    {
                        // Lấy HotelID cho khách sạn (ví dụ: Grand Hotel)
                        string queryHotelID = "SELECT HotelID FROM Hotels WHERE HotelName = @HotelName";
                        SqlCommand hotelCommand = new SqlCommand(queryHotelID, connection);
                        hotelCommand.Parameters.AddWithValue("@HotelName", associatedServiceName);
                        int hotelID = Convert.ToInt32(hotelCommand.ExecuteScalar());

                        // Thêm vào bảng Providers
                        string queryInsertProvider = "INSERT INTO Providers (UserID, ProviderName, ProviderType) VALUES (@UserID, @ProviderName, @ProviderType)";
                        SqlCommand providerCommand = new SqlCommand(queryInsertProvider, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", userId);
                        providerCommand.Parameters.AddWithValue("@ProviderName", fullName);
                        providerCommand.Parameters.AddWithValue("@ProviderType", role);

                        providerCommand.ExecuteNonQuery();

                        // Thêm vào bảng HotelEmployees để liên kết người dùng với khách sạn
                        string queryInsertHotelEmployee = "INSERT INTO HotelEmployees (UserID, HotelID) VALUES (@UserID, @HotelID)";
                        SqlCommand hotelEmployeeCommand = new SqlCommand(queryInsertHotelEmployee, connection);
                        hotelEmployeeCommand.Parameters.AddWithValue("@UserID", userId);
                        hotelEmployeeCommand.Parameters.AddWithValue("@HotelID", hotelID);

                        hotelEmployeeCommand.ExecuteNonQuery();
                    }
                    else if (role == "FlightProvider")
                    {
                        // Lấy FlightID cho chuyến bay (ví dụ: Vietnam Airlines)
                        string queryFlightID = "SELECT FlightID FROM Flights WHERE Airline = @Airline";
                        SqlCommand flightCommand = new SqlCommand(queryFlightID, connection);
                        flightCommand.Parameters.AddWithValue("@Airline", associatedServiceName);
                        int flightID = Convert.ToInt32(flightCommand.ExecuteScalar());

                        // Thêm vào bảng Providers
                        string queryInsertProvider = "INSERT INTO Providers (UserID, ProviderName, ProviderType) VALUES (@UserID, @ProviderName, @ProviderType)";
                        SqlCommand providerCommand = new SqlCommand(queryInsertProvider, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", userId);
                        providerCommand.Parameters.AddWithValue("@ProviderName", fullName);
                        providerCommand.Parameters.AddWithValue("@ProviderType", role);

                        providerCommand.ExecuteNonQuery();

                        // Thêm vào bảng FlightEmployees để liên kết người dùng với chuyến bay
                        string queryInsertFlightEmployee = "INSERT INTO FlightEmployees (UserID, FlightID) VALUES (@UserID, @FlightID)";
                        SqlCommand flightEmployeeCommand = new SqlCommand(queryInsertFlightEmployee, connection);
                        flightEmployeeCommand.Parameters.AddWithValue("@UserID", userId);
                        flightEmployeeCommand.Parameters.AddWithValue("@FlightID", flightID);

                        flightEmployeeCommand.ExecuteNonQuery();
                    }
                    else if (role == "TourProvider")
                    {
                        // Lấy TourID cho tour (ví dụ: Beach Getaway)
                        string queryTourID = "SELECT TourID FROM Tours WHERE TourName = @TourName";
                        SqlCommand tourCommand = new SqlCommand(queryTourID, connection);
                        tourCommand.Parameters.AddWithValue("@TourName", associatedServiceName);
                        int tourID = Convert.ToInt32(tourCommand.ExecuteScalar());

                        // Thêm vào bảng Providers
                        string queryInsertProvider = "INSERT INTO Providers (UserID, ProviderName, ProviderType) VALUES (@UserID, @ProviderName, @ProviderType)";
                        SqlCommand providerCommand = new SqlCommand(queryInsertProvider, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", userId);
                        providerCommand.Parameters.AddWithValue("@ProviderName", fullName);
                        providerCommand.Parameters.AddWithValue("@ProviderType", role);

                        providerCommand.ExecuteNonQuery();

                        // Thêm vào bảng TourEmployees để liên kết người dùng với tour
                        string queryInsertTourEmployee = "INSERT INTO TourEmployees (UserID, TourID) VALUES (@UserID, @TourID)";
                        SqlCommand tourEmployeeCommand = new SqlCommand(queryInsertTourEmployee, connection);
                        tourEmployeeCommand.Parameters.AddWithValue("@UserID", userId);
                        tourEmployeeCommand.Parameters.AddWithValue("@TourID", tourID);

                        tourEmployeeCommand.ExecuteNonQuery();
                    }
                    else if (role == "Admin")
                    {
                        // Thêm vào bảng Admin nếu cần (Admin không có liên kết với Providers hay các bảng liên quan khác)
                        string queryInsertProvider = "INSERT INTO Providers (UserID, ProviderName, ProviderType) VALUES (@UserID, @ProviderName, @ProviderType)";
                        SqlCommand providerCommand = new SqlCommand(queryInsertProvider, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", userId);
                        providerCommand.Parameters.AddWithValue("@ProviderName", fullName);
                        providerCommand.Parameters.AddWithValue("@ProviderType", role);

                        providerCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("User added successfully with role: " + role);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

        
       

