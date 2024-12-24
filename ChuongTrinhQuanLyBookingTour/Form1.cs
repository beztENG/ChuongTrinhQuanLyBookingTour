using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Form1 : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public Form1()
        {
            InitializeComponent();

            var loginStatus = LoginHelper.GetLoginStatus();
            if (loginStatus.HasValue)
            {
                string username = loginStatus.Value.username;
                string role = loginStatus.Value.role;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy UserID từ database
                    string query = "SELECT UserID FROM Users WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        GlobalUserInfo.UserID = Convert.ToInt32(result);
                        GlobalUserInfo.UserRole = role;

                        // Chuyển hướng đến giao diện tương ứng
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
                                HotelProviderDashboard hotelDashboard = new HotelProviderDashboard(GlobalUserInfo.HotelID);
                                this.Hide();
                                hotelDashboard.Show();
                                break;
                            case "AirlineProvider":
                                AirlineProviderDashboard airlineDashboard = new AirlineProviderDashboard(GlobalUserInfo.AirlineID);
                                this.Hide();
                                airlineDashboard.Show();
                                break;
                            case "CompanyTourProvider":
                                CompanyTourProviderDashboard companytourDashboard = new CompanyTourProviderDashboard(GlobalUserInfo.CompanyID);
                                this.Hide();
                                companytourDashboard.Show();
                                break;
                            default:
                                break;
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng.", "Lỗi");
                    }
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateLogin(username, password, out string role))
            {
                bool alwaysLogin = ckbAlwaysLogin.Checked;
                // Lưu trạng thái đăng nhập trong database
                if (alwaysLogin)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Users SET IsLoggedIn = 1 WHERE Username = @Username";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }
                }

                labelError.Visible = false;

                // Điều hướng đến Dashboard theo vai trò
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
                        HotelProviderDashboard hotelDashboard = new HotelProviderDashboard(GlobalUserInfo.HotelID);
                        this.Hide();
                        hotelDashboard.Show();
                        break;
                    case "AirlineProvider":
                        AirlineProviderDashboard airlineDashboard = new AirlineProviderDashboard(GlobalUserInfo.AirlineID);
                        this.Hide();
                        airlineDashboard.Show();
                        break;
                    case "CompanyTourProvider":
                        CompanyTourProviderDashboard companytourDashboard = new CompanyTourProviderDashboard(GlobalUserInfo.CompanyID);
                        this.Hide();
                        companytourDashboard.Show();
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
                    GlobalUserInfo.UserID = reader.GetInt32(0); // Lấy UserID từ kết quả truy vấn
                    role = reader.GetString(1);

                    GlobalUserInfo.UserRole = role;

                    reader.Close();

                    if (role == "HotelProvider" || role == "AirlineProvider" || role == "CompanyTourProvider")
                    {
                        string providerQuery = "SELECT ProviderID FROM Providers WHERE UserID = @UserID";
                        SqlCommand providerCommand = new SqlCommand(providerQuery, connection);
                        providerCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                        int providerID = (int)providerCommand.ExecuteScalar();
                        GlobalUserInfo.ProviderID = providerID;

                        if (role == "HotelProvider")
                        {
                            string hotelQuery = "SELECT HotelID FROM HotelEmployees WHERE UserID = @UserID";
                            SqlCommand hotelCommand = new SqlCommand(hotelQuery, connection);
                            hotelCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                            SqlDataReader hotelReader = hotelCommand.ExecuteReader();
                            if (hotelReader.Read())
                            {
                                GlobalUserInfo.HotelID = hotelReader.GetInt32(0);
                            }
                            hotelReader.Close();
                        }
                        else if (role == "AirlineProvider")
                        {
                            string airlineQuery = "SELECT AirlineID FROM AirlineEmployees WHERE UserID = @UserID";
                            SqlCommand airlineCommand = new SqlCommand(airlineQuery, connection);
                            airlineCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                            SqlDataReader airlineReader = airlineCommand.ExecuteReader();
                            if (airlineReader.Read())
                            {
                                GlobalUserInfo.AirlineID = airlineReader.GetInt32(0);
                            }
                            airlineReader.Close();
                        }
                        else if (role == "CompanyTourProvider")
                        {
                            string companyQuery = "SELECT CompanyID FROM CompanyTourEmployees WHERE UserID = @UserID";
                            SqlCommand companyCommand = new SqlCommand(companyQuery, connection);
                            companyCommand.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                            SqlDataReader companyReader = companyCommand.ExecuteReader();
                            if (companyReader.Read())
                            {
                                GlobalUserInfo.CompanyID = companyReader.GetInt32(0);
                            }
                            companyReader.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbAlwaysLogin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
