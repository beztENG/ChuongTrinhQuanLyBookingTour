using System;
using System.Data.SqlClient;
using System.IO;

namespace ChuongTrinhQuanLyBookingTour.Helpers
{
    public static class LoginHelper
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login_status.txt");

        public static void SaveLoginStatus(string username, string role)
        {
            string data = $"{username}|{role}";
            File.WriteAllText(filePath, data);
        }

        public static (string username, string role)? GetLoginStatus()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Role FROM Users WHERE IsLoggedIn = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string username = reader.GetString(0);
                        string role = reader.GetString(1);
                        return (username, role);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy trạng thái đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        public static void ClearLoginStatus()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
