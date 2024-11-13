using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider
{
    public partial class UC_EditFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int selectedFlightID;
        private int airlineID;

        public UC_EditFlight()
        {
            InitializeComponent();
        }

        public void SetAirlineID(int airlineID)
        {
            this.airlineID = airlineID;
            LoadFlights();
        }

        public void LoadFlights()
        {
            try
            {
                dataGridViewFlights.ReadOnly = true;
                string query = "SELECT FlightID, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, Status " +
                               "FROM Flights WHERE AirlineID = @AirlineID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AirlineID", this.airlineID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable flightsTable = new DataTable();
                    adapter.Fill(flightsTable);
                    dataGridViewFlights.DataSource = flightsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading flights: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFlights.Rows[e.RowIndex];
                selectedFlightID = Convert.ToInt32(row.Cells["FlightID"].Value);
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
            if (selectedFlightID > 0)
            {
                string query = "UPDATE Flights SET Departure = @Departure, Arrival = @Arrival, DepartureDate = @DepartureDate, " +
                               "ArrivalDate = @ArrivalDate, TakeOffTime = @TakeOffTime, LandingTime = @LandingTime, Cost = @Cost " +
                               "WHERE FlightID = @FlightID AND AirlineID = @AirlineID";

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
                    command.Parameters.AddWithValue("@FlightID", selectedFlightID);
                    command.Parameters.AddWithValue("@AirlineID", GlobalUserInfo.AirlineID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFlights();
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewFlights == null || txtSearch == null)
            {
                MessageBox.Show("Controls not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchText = txtSearch.Text.ToLower().Trim();
            bool anyRowVisible = false;

            foreach (DataGridViewRow row in dataGridViewFlights.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Index == dataGridViewFlights.CurrentCell?.RowIndex)
                {
                    row.Visible = true;
                    continue;
                }

                bool isVisible = false;

                if (row.Cells["FlightID"].Value != null && row.Cells["Departure"].Value != null && row.Cells["Arrival"].Value != null)
                {
                    string flightID = row.Cells["FlightID"].Value.ToString().ToLower();
                    string departure = row.Cells["Departure"].Value.ToString().ToLower();
                    string arrival = row.Cells["Arrival"].Value.ToString().ToLower();

                    isVisible = flightID.Contains(searchText) ||
                                departure.Contains(searchText) ||
                                arrival.Contains(searchText);
                }

                row.Visible = isVisible;
                if (isVisible) anyRowVisible = true;
            }

            if (!anyRowVisible)
            {
                dataGridViewFlights.ClearSelection();
                dataGridViewFlights.CurrentCell = null;
            }
        }

    }
}
