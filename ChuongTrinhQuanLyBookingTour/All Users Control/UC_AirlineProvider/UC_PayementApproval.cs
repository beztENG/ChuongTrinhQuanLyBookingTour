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
                
                    int airlineID = GlobalUserInfo.AirlineID;


                    string query = @"
                SELECT f.FlightBookingID, f.UserID, f.FlightID, f.BookingDate, f.Status AS BookingStatus, 
                       a.EmployeeID, a.ApprovalStatus
                FROM FlightBookings f
                LEFT JOIN FlightBookingApprovals a ON f.FlightBookingID = a.FlightBookingID
                INNER JOIN Flights fl ON f.FlightID = fl.FlightID
                WHERE fl.AirlineID = @AirlineID AND a.ApprovalStatus = 'Pending Approval'";

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
                    string updateQuery = @"
                        UPDATE FlightBookingApprovals
                        SET ApprovalStatus = 'Approved'
                        WHERE FlightBookingID = @FlightBookingID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightBookingID", bookingID);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                   

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Request approved successfully.");
                        LoadApprovalRequests();  // Reload requests after approval
                    }
                    else
                    {
                        MessageBox.Show("Error approving request.");
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
                    string updateQuery = @"
                        UPDATE FlightBookingApprovals
                        SET ApprovalStatus = 'Rejected'
                        WHERE FlightBookingID = @FlightBookingID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightBookingID", bookingID);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                  

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Request rejected successfully.");
                        LoadApprovalRequests();
                    }
                    else
                    {
                        MessageBox.Show("Error rejecting request.");
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
