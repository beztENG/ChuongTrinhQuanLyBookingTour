using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    public partial class UC_AddFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_AddFlight()
        {
            InitializeComponent();
            LoadAirlines();
            LoadAttribute();
            dgvFlights.ReadOnly = true;
        }

        // Load airlines from the database into the ComboBox
        private void LoadAirlines()
        {
            string query = "SELECT DISTINCT Airline, AirlineImage FROM Flights";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAirline.DataSource = dt;
                cmbAirline.DisplayMember = "Airline";
                cmbAirline.ValueMember = "AirlineImage";
            }
        }

        private void cmbAirline_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAirline.SelectedValue is DataRowView)
                return;

            string selectedImageName = cmbAirline.SelectedValue.ToString();
            DisplayAirlineImage(selectedImageName);
        }

        private void DisplayAirlineImage(string imageName)
        {
            string imagePath = Path.Combine(Application.StartupPath, @"Images\Flight", imageName);

            if (File.Exists(imagePath))
            {
                if (pictureBoxAirline.Image != null)
                {
                    pictureBoxAirline.Image.Dispose();
                }

                Image airlineImage = Image.FromFile(imagePath);
                pictureBoxAirline.Image = ImageHelper.ResizeImage(airlineImage, 245, 124);
            }
            else
            {
                pictureBoxAirline.Image = null;
                MessageBox.Show($"Image file '{imageName}' not found.");
            }
        }

        private void btnSearchFlights_Click(object sender, EventArgs e)
        {
            // Get the selected airline, departure, and arrival
            string selectedAirline = ((DataRowView)cmbAirline.SelectedItem)?["Airline"].ToString(); // Get airline name
            string selectedDeparture = cmbDeparture.SelectedItem?.ToString();
            string selectedArrival = cmbArrival.SelectedItem?.ToString();



            if (string.IsNullOrEmpty(selectedAirline) ||
                string.IsNullOrEmpty(selectedDeparture) ||
                string.IsNullOrEmpty(selectedArrival))
            {
                MessageBox.Show("Please select all fields (Airline, Departure, Arrival) before searching.");
                return;
            }
            LoadFlights(selectedAirline, selectedDeparture, selectedArrival);
        }

        private void LoadFlights(string airline, string departure, string arrival)
        {
            string query = @"SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime 
                     FROM Flights 
                     WHERE Airline = @Airline 
                     AND Departure = @Departure 
                     AND Arrival = @Arrival";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Airline", airline);
                cmd.Parameters.AddWithValue("@Departure", departure);
                cmd.Parameters.AddWithValue("@Arrival", arrival);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có chuyến bay nào phù hợp.");
                }
                else
                {
                    dgvFlights.DataSource = dt;
                }

                dgvFlights.DataSource = dt;

                dgvFlights.AutoResizeColumns();
            }
        }

        private void dgvFlights_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFlights.Columns[e.ColumnIndex].Name == "AirlineImage" && e.Value != null)
            {
                string imageName = e.Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, @"Images\Flight", imageName);

                if (File.Exists(imagePath))
                {
                    e.Value = Image.FromFile(imagePath);
                }
            }
        }

        private void LoadAttribute()
        {
            cmbDeparture.Items.Add("Hanoi");
            cmbDeparture.Items.Add("Ho Chi Minh City");
            cmbDeparture.Items.Add("Danang");
            cmbDeparture.Items.Add("Phu Quoc");

            cmbArrival.Items.Add("Hanoi");
            cmbArrival.Items.Add("Ho Chi Minh City");
            cmbArrival.Items.Add("Danang");
            cmbDeparture.Items.Add("Phu Quoc");
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight to book.");
                return;
            }

            DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
            int flightID = (int)selectedRow.Cells["FlightID"].Value;
            DateTime bookingDate = DateTime.Now;

            int userID = GlobalUserInfo.UserID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO FlightBookings (UserID, FlightID, BookingDate) 
                         VALUES (@UserID, @FlightID, @BookingDate)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@FlightID", flightID);
                    cmd.Parameters.AddWithValue("@BookingDate", bookingDate);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Flight booked successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while booking the flight: {ex.Message}");
                    }
                }
            }
        }

        private void UC_AddFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
