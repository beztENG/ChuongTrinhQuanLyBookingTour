using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers; 

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=TourBookingDB;Integrated Security=True";

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

            if (ValidateLogin(username, password))
            {
                labelError.Visible = false;
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();  

                if (result != null)
                {
                    int userID = Convert.ToInt32(result); 
                    GlobalUserInfo.UserID = userID;       
                    isValid = true;
                }
            }

            return isValid;
        }


        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}