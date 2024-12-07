using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider
{
    public partial class UC_PayementApproval : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int employeeID = GlobalUserInfo.UserID;

        public UC_PayementApproval()
        {
            InitializeComponent();
            LoadApprovalRequests(); 
        }

        
        private void LoadApprovalRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int airlineID = GlobalUserInfo.AirlineID;

                    string query = @"
                        SELECT f.FlightBookingID, f.UserID, f.FlightID, f.BookingDate, f.Status AS BookingStatus, 
                               a.EmployeeID, a.ApprovalStatus
                        FROM FlightBookings f
                        LEFT JOIN FlightBookingApprovals a ON f.FlightBookingID = a.FlightBookingID
                        INNER JOIN Flights fl ON f.FlightID = fl.FlightID
                        WHERE fl.AirlineID = @AirlineID AND a.ApprovalStatus = 'Pending Approval';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AirlineID", airlineID);

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

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["FlightBookingID"].Value);

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
                            // Cập nhật trạng thái trong bảng FlightBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE FlightBookingApprovals
                                SET ApprovalStatus = 'Approved'
                                WHERE FlightBookingID = @FlightBookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@FlightBookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng FlightBookings
                            string updateBookingQuery = @"
                                UPDATE FlightBookings
                                SET Status = 'Approved'
                                WHERE FlightBookingID = @FlightBookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@FlightBookingID", bookingID);
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

            int bookingID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["FlightBookingID"].Value);

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
                            // Cập nhật trạng thái trong bảng FlightBookingApprovals
                            string updateApprovalQuery = @"
                                UPDATE FlightBookingApprovals
                                SET ApprovalStatus = 'Rejected'
                                WHERE FlightBookingID = @FlightBookingID;";

                            SqlCommand cmdApproval = new SqlCommand(updateApprovalQuery, conn, transaction);
                            cmdApproval.Parameters.AddWithValue("@FlightBookingID", bookingID);
                            cmdApproval.ExecuteNonQuery();

                            // Cập nhật trạng thái trong bảng FlightBookings
                            string updateBookingQuery = @"
                                UPDATE FlightBookings
                                SET Status = 'Rejected'
                                WHERE FlightBookingID = @FlightBookingID;";

                            SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, conn, transaction);
                            cmdBooking.Parameters.AddWithValue("@FlightBookingID", bookingID);
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
