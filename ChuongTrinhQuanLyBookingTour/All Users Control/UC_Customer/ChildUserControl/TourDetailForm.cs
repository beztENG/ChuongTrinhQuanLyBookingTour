using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.ChildUserControl
{
    public partial class TourDetailForm : Form
    {
        private int tourID;
        private string connectionString = DatabaseHelper.ConnectionString; // Use the global connection string

        public TourDetailForm(int tourID)
        {
            InitializeComponent();
            this.tourID = tourID;
            LoadTourDetails();
        }

        private void LoadTourDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tours WHERE TourID = @tourID", conn);
                cmd.Parameters.AddWithValue("@tourID", tourID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTourName.Text = reader["TourName"].ToString();
                    txtStarting.Text = reader["Starting"].ToString();
                    txtDestination.Text = reader["Destination"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    txtStartDate.Text = Convert.ToDateTime(reader["StartingDate"]).ToShortDateString();
                    txtReturnDate.Text = Convert.ToDateTime(reader["ReturnDate"]).ToShortDateString();
                    txtCost.Text = reader["Cost"].ToString() + " USD";

                    txtTourName.ReadOnly = true;
                    txtStarting.ReadOnly = true;
                    txtDestination.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtStartDate.ReadOnly = true;
                    txtReturnDate.ReadOnly = true;
                    txtCost.ReadOnly = true;

                    string imagePath = Path.Combine(Application.StartupPath, @"Images\Tour", reader["TourImage"].ToString());
                    if (File.Exists(imagePath))
                    {
                        if (pictureBoxTour.Image != null)
                        {
                            pictureBoxTour.Image.Dispose();
                        }
                        Image tourImage = Image.FromFile(imagePath);
                        pictureBoxTour.Image = ImageHelper.ResizeImage(tourImage, 600, 500);
                    }
                }
                reader.Close();
            }
        }


        private void btnBookTour_Click(object sender, EventArgs e)
        {
            int userID = GlobalUserInfo.UserID;
            DateTime bookingDate = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TourBookings (TourID, UserID, BookingDate) VALUES (@tourID, @userID, @bookingDate)", conn);
                cmd.Parameters.AddWithValue("@tourID", tourID);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@bookingDate", bookingDate);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tour booked successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to book the tour. Please try again.", "Error");
                }
            }
        }
    }

}
