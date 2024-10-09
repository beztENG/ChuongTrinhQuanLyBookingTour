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
using ChuongTrinhQuanLyBookingTour.All_Users_Control.ChildUserControl;
using ChuongTrinhQuanLyBookingTour.Helpers;


namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    public partial class UC_AddTour : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString; // Use the global connection string

        public UC_AddTour()
        {
            InitializeComponent();
            LoadAttributes();
            dataGridViewTours.CellDoubleClick += dataGridViewTours_CellDoubleClick;
            dataGridViewTours.ReadOnly = true;
        }

        public void LoadAttributes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmdStarting = new SqlCommand("SELECT DISTINCT Starting FROM Tours", conn);
                SqlCommand cmdDestination = new SqlCommand("SELECT DISTINCT Destination FROM Tours", conn);

                SqlDataReader readerStarting = cmdStarting.ExecuteReader();
                while (readerStarting.Read())
                {
                    cmbStarting.Items.Add(readerStarting["Starting"].ToString());
                }
                readerStarting.Close();

                SqlDataReader readerDestination = cmdDestination.ExecuteReader();
                while (readerDestination.Read())
                {
                    cmbDestination.Items.Add(readerDestination["Destination"].ToString());
                }
                readerDestination.Close();
            }
        }

        private void btnSearchTour_Click(object sender, EventArgs e)
        {
            string starting = cmbStarting.SelectedItem != null ? cmbStarting.SelectedItem.ToString() : null;
            string destination = cmbDestination.SelectedItem != null ? cmbDestination.SelectedItem.ToString() : null;
            DateTime? startDate = dtpStartDate.Value != null ? dtpStartDate.Value.Date : (DateTime?)null;
            DateTime? returnDate = dtpReturnDate.Value != null ? dtpReturnDate.Value.Date : (DateTime?)null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                StringBuilder queryBuilder = new StringBuilder("SELECT TourName, StartingDate, ReturnDate, Cost FROM Tours WHERE 1=1");

                if (!string.IsNullOrEmpty(starting))
                {
                    queryBuilder.Append(" AND Starting = @starting");
                }
                if (!string.IsNullOrEmpty(destination))
                {
                    queryBuilder.Append(" AND Destination = @destination");
                }
                if (startDate.HasValue)
                {
                    queryBuilder.Append(" AND StartingDate >= @startDate");
                }
                if (returnDate.HasValue)
                {
                    queryBuilder.Append(" AND ReturnDate <= @returnDate");
                }

                SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);

                if (!string.IsNullOrEmpty(starting))
                {
                    cmd.Parameters.AddWithValue("@starting", starting);
                }
                if (!string.IsNullOrEmpty(destination))
                {
                    cmd.Parameters.AddWithValue("@destination", destination);
                }
                if (startDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Value);
                }
                if (returnDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@returnDate", returnDate.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewTours.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No tours found with the selected criteria.", "Search Results");
                }
            }
        }


        private void btnBookTour_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tour to book.");
                return;
            }

            string selectedTourName = dataGridViewTours.SelectedRows[0].Cells["TourName"].Value.ToString();
            DateTime bookingDate = DateTime.Now;

            int tourID = GetTourIDByName(selectedTourName);
            int userID = GlobalUserInfo.UserID; 

            if (tourID == -1 || userID == -1)
            {
                MessageBox.Show("Error retrieving TourID or UserID.");
                return;
            }

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

        private int GetTourIDByName(string tourName)
        {
            int tourID = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TourID FROM Tours WHERE TourName = @tourName", conn);
                cmd.Parameters.AddWithValue("@tourName", tourName);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tourID = Convert.ToInt32(reader["TourID"]);
                }
                reader.Close();
            }

            return tourID;
        }

        private void dataGridViewTours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedTourName = dataGridViewTours.Rows[e.RowIndex].Cells["TourName"].Value.ToString();

                int tourID = GetTourIDByName(selectedTourName);

                if (tourID != -1)
                {
                    TourDetailForm detailForm = new TourDetailForm(tourID);
                    detailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error retrieving the Tour ID.");
                }
            }
        }

    }
}
