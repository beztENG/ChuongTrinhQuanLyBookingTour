using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    public partial class UC_AddRoom : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom(string roomType, string bedType, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int hotelID = GlobalUserInfo.HotelID;  

                string checkHotelQuery = "SELECT COUNT(*) FROM Hotels WHERE HotelID = @HotelID";
                SqlCommand checkHotelCommand = new SqlCommand(checkHotelQuery, connection);
                checkHotelCommand.Parameters.AddWithValue("@HotelID", hotelID);

                int hotelExists = (int)checkHotelCommand.ExecuteScalar();
                if (hotelExists == 0)
                {
                    MessageBox.Show("Invalid Hotel ID. Please ensure you are associated with a valid hotel.");
                    return;
                }

                string query = "INSERT INTO Rooms (HotelID, RoomType, BedType, Price) VALUES (@HotelID, @RoomType, @BedType, @Price)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HotelID", hotelID);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@BedType", bedType);
                command.Parameters.AddWithValue("@Price", price);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Room added successfully.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error adding room: " + ex.Message);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string roomType = txtRoomType.Text;
            string bedType = txtBedType.Text;
            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(bedType))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AddRoom(roomType, bedType, price);
        }
    }
}
