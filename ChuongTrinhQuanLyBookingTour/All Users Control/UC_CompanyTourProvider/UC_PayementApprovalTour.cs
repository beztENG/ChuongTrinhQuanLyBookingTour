using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_CompanyTourProvider
{
    public partial class UC_PayementApprovalTour : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int employeeID = GlobalUserInfo.UserID;

        public UC_PayementApprovalTour()
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

                    int companyTourID = GlobalUserInfo.CompanyID;

                    string query = @"
                        SELECT tb.TourBookingID, tb.UserID, tb.TourID, tb.BookingDate, tb.Status AS BookingStatus, tba.EmployeeID, tba.ApprovalStatus
                        FROM TourBookings tb
                        LEFT JOIN TourBookingApprovals tba ON tb.TourBookingID = tba.TourBookingID
                        INNER JOIN Tours t ON tb.TourID = t.TourID
                        WHERE t.CompanyID = @CompanyID AND tba.ApprovalStatus = 'Pending Approval';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompanyID", companyTourID);

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

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["TourBookingID"].Value);

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
                            // Cập nhật trạng thái trong bảng TourBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE TourBookingApprovals
                                SET ApprovalStatus = 'Approved'
                                WHERE TourBookingID = @TourBookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@TourBookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng TourBookings
                            string updateBookingQuery = @"
                                UPDATE TourBookings
                                SET Status = 'Approved'
                                WHERE TourBookingID = @TourBookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@TourBookingID", bookingID);
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

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["TourBookingID"].Value);

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
                            // Cập nhật trạng thái trong bảng TourBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE TourBookingApprovals
                                SET ApprovalStatus = 'Rejected'
                                WHERE TourBookingID = @TourBookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@TourBookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng TourBookings
                            string updateBookingQuery = @"
                                UPDATE TourBookings
                                SET Status = 'Rejected'
                                WHERE TourBookingID = @TourBookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@TourBookingID", bookingID);
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
