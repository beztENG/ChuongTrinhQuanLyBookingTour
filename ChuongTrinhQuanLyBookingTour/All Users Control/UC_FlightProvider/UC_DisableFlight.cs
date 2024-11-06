using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_FlightProvider
{
    public partial class UC_DisableFlight : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public UC_DisableFlight()
        {
            InitializeComponent();
            LoadFlights();
        }

        public void LoadFlights()
        {
            dgvFlights.ReadOnly = true;
            string query = @"SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, Status
                             FROM Flights
                             WHERE ProviderID = @ProviderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProviderID", GlobalUserInfo.ProviderID);
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

            string updateQuery = "UPDATE Flights SET Status = @Status WHERE FlightID = @FlightID AND ProviderID = @ProviderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@FlightID", flightID);
                cmd.Parameters.AddWithValue("@ProviderID", GlobalUserInfo.ProviderID);

                cmd.ExecuteNonQuery();
                MessageBox.Show(isCurrentlyEnabled ? "Flight disabled successfully!" : "Flight enabled successfully!");
            }

            // Refresh the DataGridView
            LoadFlights();
        }
    }
}
