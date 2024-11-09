using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class UC_ManageHotelBrand : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int selectedHotelId = -1; 

        public UC_ManageHotelBrand()
        {
            InitializeComponent();
            LoadHotelData();
            ClearFields();
        }

        private void LoadHotelData()
        {
            string query = "SELECT * FROM Hotels";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable hotelsTable = new DataTable();
                    adapter.Fill(hotelsTable);
                    dgvHotelBrands.DataSource = hotelsTable;
                }
            }
        }

        private void dgvHotelBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHotelBrands.Rows[e.RowIndex];
                selectedHotelId = Convert.ToInt32(row.Cells["HotelID"].Value);

                txtHotelName.Text = dgvHotelBrands.Rows[e.RowIndex].Cells["HotelName"].Value.ToString();
                txtLocation.Text = dgvHotelBrands.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                txtRating.Text = dgvHotelBrands.Rows[e.RowIndex].Cells["Rating"].Value.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string hotelName = txtHotelName.Text.Trim();
            string location = txtLocation.Text.Trim();
            string ratingText = txtRating.Text.Trim();
            float rating;

            if (string.IsNullOrEmpty(hotelName) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(ratingText))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!float.TryParse(ratingText, out rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating should be a number between 1 and 5.");
                return;
            }

            string query = "INSERT INTO Hotels (HotelName, HotelImage, Location, Rating) VALUES (@HotelName, @HotelImage, @Location, @Rating)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HotelName", hotelName);
                    command.Parameters.AddWithValue("@HotelImage", DBNull.Value);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Rating", rating);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Hotel brand added successfully!");
                        ClearFields();
                        LoadHotelData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to add hotel brand.");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedHotelId < 0)
            {
                MessageBox.Show("Please select a hotel to update.");
                return;
            }

            string hotelName = txtHotelName.Text.Trim();
            string location = txtLocation.Text.Trim();
            string ratingText = txtRating.Text.Trim();
            float rating;

            if (string.IsNullOrEmpty(hotelName) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(ratingText))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!float.TryParse(ratingText, out rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating should be a number between 1 and 5.");
                return;
            }

            string query = "UPDATE Hotels SET HotelName = @HotelName, Location = @Location, Rating = @Rating WHERE HotelID = @HotelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HotelName", hotelName);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Rating", rating);
                    command.Parameters.AddWithValue("@HotelID", selectedHotelId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Hotel brand updated successfully!");
                        ClearFields();
                        LoadHotelData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to update hotel brand.");
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtHotelName.Clear();
            txtLocation.Clear();
            txtRating.Clear();
            selectedHotelId = -1; // Reset selected ID
        }
    }
}
