using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            string connectionString = DatabaseHelper.ConnectionString;

            string username = null;
            string role = null;
            int userID;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryID = "SELECT UserID FROM Users WHERE IsLoggedIn = 1";
                SqlCommand cmdID = new SqlCommand(queryID, conn);
                object resultID = cmdID.ExecuteScalar();
                if (resultID != null)
                {
                    GlobalUserInfo.UserID = Convert.ToInt32(resultID);
                }

                string query = "SELECT Username, Role FROM Users WHERE IsLoggedIn = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                  
                    username = reader.GetString(0);
                    role = reader.GetString(1);
                    GlobalUserInfo.UserRole = role;
                }
            }

            if (!string.IsNullOrEmpty(username))
            {
                // Mở Dashboard theo role
                switch (role)
                {
                    case "Admin":
                        Application.Run(new AdminDashboard());
                        break;
                    case "Customer":
                        Application.Run(new Dashboard());
                        break;
                    case "HotelProvider":
                        Application.Run(new HotelProviderDashboard(GlobalUserInfo.HotelID));
                        break;
                    case "AirlineProvider":
                        Application.Run(new AirlineProviderDashboard(GlobalUserInfo.AirlineID));
                        break;
                    case "CompanyTourProvider":
                        Application.Run(new CompanyTourProviderDashboard(GlobalUserInfo.CompanyID));
                        break;
                    default:
                        MessageBox.Show("Unauthorized role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {       
                Application.Run(new Form1());
            }
        }
    }
}
