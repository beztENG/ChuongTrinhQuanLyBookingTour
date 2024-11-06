using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_FlightProvider
{
    public partial class UC_AddNewFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_AddNewFlight()
        {
            InitializeComponent();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string airline = GlobalUserInfo.Airline;
            string airlineImage = GlobalUserInfo.AirlineImage;

            string departure = txtDeparture.Text;
            string arrival = txtArrival.Text;
            DateTime departureDate = dtpDepartureDate.Value.Date;
            DateTime arrivalDate = dtpArrivalDate.Value.Date;
            TimeSpan takeOffTime = TimeSpan.Parse(txtTakeOffTime.Text);
            TimeSpan landingTime = TimeSpan.Parse(txtLandingTime.Text);
            decimal cost;

            if (!decimal.TryParse(txtCost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid cost.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Flights (Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, AirlineImage, ProviderID, status) " +
                           "VALUES (@Airline, @Departure, @Arrival, @DepartureDate, @ArrivalDate, @TakeOffTime, @LandingTime, @Cost, @AirlineImage, @ProviderID, 1)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Airline", airline);
                    command.Parameters.AddWithValue("@Departure", departure);
                    command.Parameters.AddWithValue("@Arrival", arrival);
                    command.Parameters.AddWithValue("@DepartureDate", departureDate);
                    command.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
                    command.Parameters.AddWithValue("@TakeOffTime", takeOffTime);
                    command.Parameters.AddWithValue("@LandingTime", landingTime);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.Parameters.AddWithValue("@AirlineImage", airlineImage);
                    command.Parameters.AddWithValue("@ProviderID", GlobalUserInfo.ProviderID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding flight: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
