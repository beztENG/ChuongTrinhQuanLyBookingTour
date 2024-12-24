using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class HotelProviderDashboard : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int hotelId;

        public HotelProviderDashboard(int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
        }
        private void HotelProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddRoom.PerformClick();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.BringToFront();
            uC_AddRoom1.Visible = true;
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            uC_EditRoom1.LoadRoomData();
            uC_EditRoom1.BringToFront();
            uC_EditRoom1.Visible = true;
        }

        private void btnDisableRoom_Click(object sender, EventArgs e)
        {
            uC_DisableRoom1.BringToFront();
            uC_DisableRoom1.Visible = true;
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
            uC_PayementApprovalHotel1.BringToFront();
            uC_PayementApprovalHotel1.Visible = true;
        }

        private void uC_PayementApprovalHotel1_Load(object sender, EventArgs e)
        {

        }
    }
}
