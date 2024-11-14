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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvRooms == null || txtSearch == null)
            {
                MessageBox.Show("Controls not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchText = txtSearch.Text.ToLower().Trim();
            bool anyRowVisible = false;

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Index == dgvRooms.CurrentCell?.RowIndex)
                {
                    row.Visible = true;
                    continue;
                }

                bool isVisible = false;

                if (row.Cells["RoomID"].Value != null && row.Cells["RoomType"].Value != null && row.Cells["BedType"].Value != null && row.Cells["Price"].Value != null)
                {
                    string roomId = row.Cells["RoomID"].Value.ToString().ToLower();
                    string roomType = row.Cells["RoomType"].Value.ToString().ToLower();
                    string bedtype = row.Cells["BedType"].Value.ToString().ToLower();
                    string price = row.Cells["Price"].Value.ToString().ToLower();

                    isVisible = roomId.Contains(searchText) ||
                                roomType.Contains(searchText) ||
                                bedtype.Contains(searchText) ||
                                price.Contains(searchText);
                }

                row.Visible = isVisible;
                if (isVisible) anyRowVisible = true;
            }

            if (!anyRowVisible)
            {
                dgvRooms.ClearSelection();
                dgvRooms.CurrentCell = null;
            }
        }
    }
}
