using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class UC_ManageHotelBrand : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        public UC_ManageHotelBrand()
        {
            InitializeComponent();
            ClearFields();
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

          

            // Thêm dữ liệu vào cơ sở dữ liệu
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
                    }
                    else
                    {
                        MessageBox.Show("Failed to add hotel brand.");
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtHotelName.Clear();
            txtLocation.Clear();
            txtRating.Clear();
        }
    }
}
