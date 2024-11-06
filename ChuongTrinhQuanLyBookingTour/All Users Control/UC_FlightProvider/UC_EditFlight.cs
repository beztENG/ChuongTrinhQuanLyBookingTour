using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_FlightProvider
{
    public partial class UC_EditFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_EditFlight()
        {
            InitializeComponent();
            LoadFlights();
        }

        public void LoadFlights()
        {
            dataGridViewFlights.ReadOnly = true;
            string query = "SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost " +
                           "FROM Flights WHERE ProviderID = @ProviderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProviderID", GlobalUserInfo.ProviderID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable flightsTable = new DataTable();
                adapter.Fill(flightsTable);
                dataGridViewFlights.DataSource = flightsTable;
            }
        }



        private void dataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFlights.Rows[e.RowIndex];
                txtFlightID.Text = row.Cells["FlightID"].Value.ToString();
                txtDeparture.Text = row.Cells["Departure"].Value.ToString();
                txtArrival.Text = row.Cells["Arrival"].Value.ToString();
                dtpDepartureDate.Value = Convert.ToDateTime(row.Cells["DepartureDate"].Value);
                dtpArrivalDate.Value = Convert.ToDateTime(row.Cells["ArrivalDate"].Value);
                txtTakeOffTime.Text = row.Cells["TakeOffTime"].Value.ToString();
                txtLandingTime.Text = row.Cells["LandingTime"].Value.ToString();
                txtCost.Text = row.Cells["Cost"].Value.ToString();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFlightID.Text, out int flightID))
            {
                string query = "UPDATE Flights SET Departure = @Departure, Arrival = @Arrival, DepartureDate = @DepartureDate, " +
                               "ArrivalDate = @ArrivalDate, TakeOffTime = @TakeOffTime, LandingTime = @LandingTime, Cost = @Cost " +
                               "WHERE FlightID = @FlightID AND ProviderID = @ProviderID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Departure", txtDeparture.Text);
                    command.Parameters.AddWithValue("@Arrival", txtArrival.Text);
                    command.Parameters.AddWithValue("@DepartureDate", dtpDepartureDate.Value);
                    command.Parameters.AddWithValue("@ArrivalDate", dtpArrivalDate.Value);
                    command.Parameters.AddWithValue("@TakeOffTime", TimeSpan.Parse(txtTakeOffTime.Text));
                    command.Parameters.AddWithValue("@LandingTime", TimeSpan.Parse(txtLandingTime.Text));
                    command.Parameters.AddWithValue("@Cost", decimal.Parse(txtCost.Text));
                    command.Parameters.AddWithValue("@FlightID", flightID);
                    command.Parameters.AddWithValue("@ProviderID", GlobalUserInfo.ProviderID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFlights();
                }
            }
            else
            {
                MessageBox.Show("Invalid Flight ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
