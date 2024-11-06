using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_TourProvider
{
    public partial class UC_DisableTour : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int providerID;

        public UC_DisableTour()
        {
            InitializeComponent();
        }

        public void SetProviderID(int providerID)
        {
            this.providerID = providerID;
            LoadTours();
        }

        private void LoadTours()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TourID, TourName, Status FROM Tours WHERE ProviderID = @ProviderID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ProviderID", providerID);
                DataTable toursTable = new DataTable();
                adapter.Fill(toursTable);

                dataGridViewTours.DataSource = toursTable;

                if (!dataGridViewTours.Columns.Contains("ToggleStatus"))
                {
                    DataGridViewButtonColumn toggleButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Toggle Status",
                        Text = "Enable/Disable",
                        UseColumnTextForButtonValue = true,
                        Name = "ToggleStatus"
                    };
                    dataGridViewTours.Columns.Add(toggleButtonColumn);
                }
            }
        }

        private void dataGridViewTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTours.Columns[e.ColumnIndex].Name == "ToggleStatus")
            {
                int tourID = Convert.ToInt32(dataGridViewTours.Rows[e.RowIndex].Cells["TourID"].Value);
                int currentStatus = Convert.ToInt32(dataGridViewTours.Rows[e.RowIndex].Cells["Status"].Value);

                int newStatus = (currentStatus == 0) ? 1 : 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Tours SET Status = @Status WHERE TourID = @TourID AND ProviderID = @ProviderID";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@TourID", tourID);
                    command.Parameters.AddWithValue("@ProviderID", providerID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    dataGridViewTours.Rows[e.RowIndex].Cells["Status"].Value = newStatus;
                    MessageBox.Show("Tour status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
