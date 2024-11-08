using ChuongTrinhQuanLyBookingTour.Helpers;
using Guna.UI2.WinForms;
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
    public partial class UC_ListUsers : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        public UC_ListUsers()
        {
            InitializeComponent();
        }
        private void LoadUserData()
        {
            // Kết nối đến cơ sở dữ liệu và lấy danh sách người dùng
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, FullName, Email, Phone, Role FROM Users";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dgvUser.DataSource = dataTable; // Gán dữ liệu vào Guna2DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void UC_ListUsers_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
