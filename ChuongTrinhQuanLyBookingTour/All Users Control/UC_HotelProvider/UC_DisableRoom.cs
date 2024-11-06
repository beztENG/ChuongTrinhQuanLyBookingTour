using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    public partial class UC_DisableRoom : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        int hotelId = GlobalUserInfo.HotelID;

        public UC_DisableRoom()
        {
            InitializeComponent();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            dgvRooms.ReadOnly = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomID, RoomType, BedType, Price, Status FROM Rooms WHERE HotelID = @HotelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HotelID", hotelId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable roomTable = new DataTable();
                        adapter.Fill(roomTable);

                        dgvRooms.DataSource = roomTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                int roomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);
                bool currentStatus = Convert.ToBoolean(dgvRooms.CurrentRow.Cells["Status"].Value);
                bool newStatus = !currentStatus;

                if (UpdateRoomStatus(roomId, newStatus))
                {
                    MessageBox.Show($"Room status updated successfully to {(newStatus ? "Enabled" : "Disabled")}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomData();
                }
                else
                {
                    MessageBox.Show("Failed to update room status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool UpdateRoomStatus(int roomId, bool newStatus)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Rooms SET Status = @Status WHERE RoomID = @RoomID AND HotelID = @HotelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@RoomID", roomId);
                        command.Parameters.AddWithValue("@HotelID", hotelId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room status: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
