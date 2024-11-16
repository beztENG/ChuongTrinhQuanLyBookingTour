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

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnUserList.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUsers1.BringToFront();
            uC_AddUsers1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            uC_ListUsers1.BringToFront();
            uC_ListUsers1.Visible = true;
        }

        private void btnManageHotelBrand_Click(object sender, EventArgs e)
        {
            uC_ManageHotelBrand1.BringToFront();
            uC_ManageHotelBrand1.Visible = true;
        }

        private void btnManageCompanyTour_Click(object sender, EventArgs e)
        {
            uC_ManageTourBrand1.BringToFront();
            uC_ManageTourBrand1.Visible = true;
        }

        private void btnManageAirline_Click(object sender, EventArgs e)
        {
            uC_ManageAirlineBrand2.BringToFront();
            uC_ManageAirlineBrand2.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (GlobalUserInfo.UserID == 0)
            {
                MessageBox.Show("Không thể đăng xuất vì không có UserID.", "Lỗi Logout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET IsLoggedIn = 0 WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", GlobalUserInfo.UserID);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã đăng xuất thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật trạng thái đăng xuất.", "Lỗi Logout");
                }
            }

            // Đóng tất cả form và mở lại màn hình đăng nhập
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
            new Form1().Show();
        }
    }
}
