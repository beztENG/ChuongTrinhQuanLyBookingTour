using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    public partial class UC_PayementApprovalHotel : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int employeeID = GlobalUserInfo.UserID;

        public UC_PayementApprovalHotel()
        {
            InitializeComponent();
            LoadApprovalRequests(); // Tải danh sách yêu cầu cần phê duyệt khi trang được tạo
        }

        // Phương thức tải danh sách yêu cầu thanh toán từ cơ sở dữ liệu
        private void LoadApprovalRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int hotelID = GlobalUserInfo.HotelID;

                    string query = @"
                        SELECT hb.BookingID, hb.UserID, hb.HotelID, hb.BookingDate, hb.Status AS BookingStatus, 
                               hba.EmployeeID, hba.ApprovalStatus
                        FROM HotelBookings hb
                        LEFT JOIN HotelBookingApprovals hba ON hb.BookingID = hba.BookingID
                        INNER JOIN Hotels ht ON hb.HotelID = ht.HotelID
                        WHERE ht.HotelID = @HotelID AND hba.ApprovalStatus = 'Pending Approval';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HotelID", hotelID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Hiển thị danh sách yêu cầu trong DataGridView
                    dgvOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading approval requests: {ex.Message}");
                }
            }
        }

        // Phê duyệt yêu cầu thanh toán
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to approve.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["BookingID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Bắt đầu giao dịch
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Cập nhật trạng thái trong bảng HotelBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE HotelBookingApprovals
                                SET ApprovalStatus = 'Approved'
                                WHERE BookingID = @BookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng HotelBookings
                            string updateBookingQuery = @"
                                UPDATE HotelBookings
                                SET Status = 'Approved'
                                WHERE BookingID = @BookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdBooking.ExecuteNonQuery();

                            // Commit giao dịch
                            transaction.Commit();

                            MessageBox.Show("Request approved successfully.");
                            LoadApprovalRequests(); // Reload requests after approval
                        }
                        catch
                        {
                            // Rollback nếu có lỗi
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error approving request: {ex.Message}");
                }
            }
        }

        // Từ chối yêu cầu thanh toán
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to reject.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["BookingID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Bắt đầu giao dịch
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Cập nhật trạng thái trong bảng HotelBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE HotelBookingApprovals
                                SET ApprovalStatus = 'Rejected'
                                WHERE BookingID = @BookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng HotelBookings
                            string updateBookingQuery = @"
                                UPDATE HotelBookings
                                SET Status = 'Rejected'
                                WHERE BookingID = @BookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdBooking.ExecuteNonQuery();

                            // Commit giao dịch
                            transaction.Commit();

                            MessageBox.Show("Request rejected successfully.");
                            LoadApprovalRequests(); // Reload requests after rejection
                        }
                        catch
                        {
                            // Rollback nếu có lỗi
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error rejecting request: {ex.Message}");
                }
            }
        }
    }
}
