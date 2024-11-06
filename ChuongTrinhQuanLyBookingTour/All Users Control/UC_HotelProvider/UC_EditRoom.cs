using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    public partial class UC_EditRoom : UserControl
    {
        int hotelId = GlobalUserInfo.HotelID;
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_EditRoom()
        {
            
            InitializeComponent();
            LoadRoomData();
        }

        public void LoadRoomData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomID, RoomType, BedType, Price FROM Rooms WHERE HotelID = @HotelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HotelID", hotelId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable roomTable = new DataTable();
                        adapter.Fill(roomTable);

                        if (roomTable.Rows.Count > 0)
                        {
                            dgvRooms.DataSource = roomTable;
                        }
                        //else
                        //{
                        //    MessageBox.Show($"No rooms found for this hotel (Hotel ID: {hotelId}).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roomType = txtSearchRoomType.Text.Trim();
            string bedType = txtSearchBedType.Text.Trim();
            decimal minPrice, maxPrice;
            decimal.TryParse(txtSearchMinPrice.Text, out minPrice);
            decimal.TryParse(txtSearchMaxPrice.Text, out maxPrice);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomID, RoomType, BedType, Price FROM Rooms WHERE HotelID = @HotelID";

                    if (!string.IsNullOrEmpty(roomType))
                        query += " AND RoomType LIKE @RoomType";
                    if (!string.IsNullOrEmpty(bedType))
                        query += " AND BedType LIKE @BedType";
                    if (minPrice > 0)
                        query += " AND Price >= @MinPrice";
                    if (maxPrice > 0)
                        query += " AND Price <= @MaxPrice";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HotelID", hotelId);
                        if (!string.IsNullOrEmpty(roomType))
                            command.Parameters.AddWithValue("@RoomType", $"%{roomType}%");
                        if (!string.IsNullOrEmpty(bedType))
                            command.Parameters.AddWithValue("@BedType", $"%{bedType}%");
                        if (minPrice > 0)
                            command.Parameters.AddWithValue("@MinPrice", minPrice);
                        if (maxPrice > 0)
                            command.Parameters.AddWithValue("@MaxPrice", maxPrice);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredTable = new DataTable();
                        adapter.Fill(filteredTable);
                        dgvRooms.DataSource = filteredTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRooms.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                int roomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                LoadRoomDetails(roomId);
            }
        }

        private void LoadRoomDetails(int roomId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomType, BedType, Price FROM Rooms WHERE RoomID = @RoomID AND HotelID = @HotelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", roomId);
                        command.Parameters.AddWithValue("@HotelID", hotelId);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtRoomType.Text = reader["RoomType"].ToString();
                            txtBedType.Text = reader["BedType"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Room details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading room details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateRoomDetails(int roomId, string roomType, string bedType, decimal price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Rooms SET RoomType = @RoomType, BedType = @BedType, Price = @Price WHERE RoomID = @RoomID AND HotelID = @HotelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", roomId);
                        command.Parameters.AddWithValue("@RoomType", roomType);
                        command.Parameters.AddWithValue("@BedType", bedType);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@HotelID", hotelId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                int roomId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value);
                string roomType = txtRoomType.Text;
                string bedType = txtBedType.Text;
                if (decimal.TryParse(txtPrice.Text, out decimal price) && !string.IsNullOrWhiteSpace(roomType) && !string.IsNullOrWhiteSpace(bedType))
                {
                    bool isUpdated = UpdateRoomDetails(roomId, roomType, bedType, price);
                    if (isUpdated)
                    {
                        MessageBox.Show("Room details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update room details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
