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
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class AirlineProviderDashboard : Form
    {
        private int airlineID;
        private string connectionString = DatabaseHelper.ConnectionString;
        public AirlineProviderDashboard(int airlineID)
        {
            InitializeComponent();
            this.airlineID = airlineID;
        }

        private void FlightProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddFlight.PerformClick();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            uC_AddNewFlight1.BringToFront();
            uC_AddNewFlight1.Visible = true;
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            uC_EditFlight2.SetAirlineID(this.airlineID);
            uC_EditFlight2.BringToFront();
            uC_EditFlight2.Visible = true;
        }

        private void btnDisableFlight_Click(object sender, EventArgs e)
        {
            uC_DisableFlight1.SetAirlineID(this.airlineID);
            uC_DisableFlight1.BringToFront();
            uC_DisableFlight1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_HotelProviderInformation1.BringToFront();
            uC_HotelProviderInformation1.Visible = true;
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

            // Đóng form AdminDashboard và mở lại màn hình đăng nhập
            this.Hide(); // Ẩn form hiện tại thay vì đóng
            Form1 loginForm = new Form1();
            loginForm.Show();
        }


        private void btnApproval_Click(object sender, EventArgs e)
        {
            uC_PayementApproval1.BringToFront();
            uC_PayementApproval1.Visible = true;
        }
    }
}
