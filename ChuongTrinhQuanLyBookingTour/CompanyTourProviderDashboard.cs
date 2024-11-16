using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_CompanyTourProvider;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class CompanyTourProviderDashboard : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int companyid;
        public CompanyTourProviderDashboard(int companyid)
        {
            InitializeComponent();
            this.companyid = companyid;
        }
        private void TourProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddNewTour.PerformClick();
        }

        private void btnAddNewTour_Click(object sender, EventArgs e)
        {
            uC_AddNewTour2.BringToFront();
            uC_AddNewTour2.Visible = true;
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            uC_EditTour1.SetCompanyID(companyid);
            uC_EditTour1.BringToFront();
            uC_EditTour1.Visible = true;
        }

        private void btnDisableTour_Click(object sender, EventArgs e)
        {
            uC_DisableTour1.SetCompanyID(companyid);
            uC_DisableTour1.BringToFront();
            uC_DisableTour1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_HotelProviderInformation1.BringToFront();
            uC_HotelProviderInformation1.Visible = true;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
