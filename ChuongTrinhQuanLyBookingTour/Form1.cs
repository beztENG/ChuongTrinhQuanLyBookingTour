using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;
using Microsoft.VisualBasic.ApplicationServices;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Form1 : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateLogin(username, password, out string role))
            {
                labelError.Visible = false;

                switch (role)
                {
                    case "Admin":
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                        break;

                    case "Customer":
                        Dashboard customerDashboard = new Dashboard();
                        this.Hide();
                        customerDashboard.Show();
                        break;

                    case "HotelProvider":
                        int hotelId = GlobalUserInfo.HotelID;
                        HotelProviderDashboard hotelDashboard = new HotelProviderDashboard(hotelId);
                        this.Hide();
                        hotelDashboard.Show();
                        break;

                    case "FlightProvider":
                        string airline = GlobalUserInfo.Airline;
                        FlightProviderDashboard flightDashboard = new FlightProviderDashboard(airline);
                        this.Hide();
                        flightDashboard.Show();
                        break;

                    case "TourProvider":
                        TourProviderDashboard tourDashboard = new TourProviderDashboard(GlobalUserInfo.ProviderID);
                        this.Hide();
                        tourDashboard.Show();
                        break;

                    default:
                        MessageBox.Show("Unauthorized role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private bool ValidateLogin(string username, string password, out string role)
        {
            bool isValid = false;
            role = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Role FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userID = reader.GetInt32(0);
                    role = reader.GetString(1);

                    GlobalUserInfo.UserID = userID;  
                    GlobalUserInfo.UserRole = role; 

                    reader.Close();

                    
                    if (role == "HotelProvider" || role == "FlightProvider" || role == "TourProvider")
                    {
                        string providerQuery = "SELECT ProviderID FROM Providers WHERE UserID = @UserID";
                        SqlCommand providerCommand = new SqlCommand(providerQuery, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                        int providerID = (int)providerCommand.ExecuteScalar();
                        GlobalUserInfo.ProviderID = providerID;

                        if (role == "HotelProvider")
                        {
                            string hotelQuery = "SELECT HotelID FROM Hotels WHERE ProviderID = @ProviderID";
                            SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection);
                            hotelCommand.Parameters.AddWithValue("@ProviderID", providerID);

                            SqlDataReader hotelReader = hotelCommand.ExecuteReader();
                            if (hotelReader.Read())
                            {
                                GlobalUserInfo.HotelID = hotelReader.GetInt32(0);
                            }
                            hotelReader.Close();
                        }
                        else if (role == "FlightProvider")
                        {
                            string airlineQuery = @"SELECT Airlines.AirlineName, Airlines.AirlineImage
                            FROM Providers
                            JOIN Airlines ON Providers.ProviderID = Airlines.ProviderID
                            WHERE Providers.UserID = @UserID";
                            SqlCommand airlineCommand = new SqlCommand(airlineQuery, connection);
                            airlineCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                            SqlDataReader airlineReader = airlineCommand.ExecuteReader();
                            if (airlineReader.Read())
                            {
                                GlobalUserInfo.Airline = airlineReader.GetString(0); 
                                GlobalUserInfo.AirlineImage = airlineReader.GetString(1);
                            }
                            airlineReader.Close();
                        }
                    }

                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }



        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
