using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider
{
    public partial class UC_DisableFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int airlineID;
        public UC_DisableFlight()
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
            dgvFlights.ReadOnly = true;
            string query = @"SELECT FlightID, Departure, Arrival, DepartureDate, ArrivalDate, Status
                             FROM Flights
                             WHERE AirlineID = @AirlineID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AirlineID", GlobalUserInfo.AirlineID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFlights.DataSource = dt;
                dgvFlights.Columns["Status"].HeaderText = "Enabled";
                dgvFlights.Columns["Status"].Visible = true;
            }
        }

        private void btnToggleFlightStatus_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight to enable or disable.");
                return;
            }

            DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
            int flightID = Convert.ToInt32(selectedRow.Cells["FlightID"].Value);
            bool isCurrentlyEnabled = Convert.ToBoolean(selectedRow.Cells["Status"].Value);

            int newStatus = isCurrentlyEnabled ? 0 : 1;

            string updateQuery = "UPDATE Flights SET Status = @Status WHERE FlightID = @FlightID AND AirlineID = @AirlineID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@FlightID", flightID);
                cmd.Parameters.AddWithValue("@AirlineID", GlobalUserInfo.AirlineID);

                cmd.ExecuteNonQuery();
                MessageBox.Show(isCurrentlyEnabled ? "Flight disabled successfully!" : "Flight enabled successfully!");
            }

            // Refresh the DataGridView
            LoadFlights();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvFlights == null || txtSearch == null)
            {
                MessageBox.Show("Controls not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchText = txtSearch.Text.ToLower().Trim();
            bool anyRowVisible = false;

            foreach (DataGridViewRow row in dgvFlights.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Index == dgvFlights.CurrentCell?.RowIndex)
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
                dgvFlights.ClearSelection();
                dgvFlights.CurrentCell = null;
            }
        }
    }
}
