using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class AnalyzeBrandForm : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public AnalyzeBrandForm()
        {
            InitializeComponent();
        }

        private void AnalyzeBrandForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with brand types
            cbBrandType.Items.AddRange(new string[] { "Hotel", "Airline", "Tour Company" });
            cbBrandType.SelectedIndex = 0;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string selectedBrandType = cbBrandType.SelectedItem.ToString();
            DataTable data = GetApprovedOrders(selectedBrandType);
            dgvResults.DataSource = data;
            UpdateChart(data);
        }

        private DataTable GetApprovedOrders(string brandType)
        {
            string query = "";

            switch (brandType)
            {
                case "Hotel":
                    query = @"
                        SELECT h.HotelName AS Brand, COUNT(hb.BookingID) AS ApprovedOrders
                        FROM HotelBookings hb
                        JOIN Rooms r ON hb.RoomID = r.RoomID
                        JOIN Hotels h ON r.HotelID = h.HotelID
                        WHERE hb.Status = 'Approved'
                        GROUP BY h.HotelName;";
                    break;

                case "Airline":
                    query = @"
                        SELECT a.AirlineName AS Brand, COUNT(fb.FlightBookingID) AS ApprovedOrders
                        FROM FlightBookings fb
                        JOIN Flights f ON fb.FlightID = f.FlightID
                        JOIN Airlines a ON f.AirlineID = a.AirlineID
                        WHERE fb.Status = 'Approved'
                        GROUP BY a.AirlineName;";
                    break;

                case "Tour Company":
                    query = @"
                        SELECT ct.CompanyName AS Brand, COUNT(tb.TourBookingID) AS ApprovedOrders
                        FROM TourBookings tb
                        JOIN Tours t ON tb.TourID = t.TourID
                        JOIN CompanyTours ct ON t.CompanyID = ct.CompanyID
                        WHERE tb.Status = 'Approved'
                        GROUP BY ct.CompanyName;";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void UpdateChart(DataTable data)
        {
            chartResults.Series.Clear();
            chartResults.ChartAreas.Clear();

            chartResults.ChartAreas.Add(new ChartArea("MainArea"));
            Series series = new Series
            {
                Name = "ApprovedOrders",
                ChartType = SeriesChartType.Column,
                XValueMember = "Brand",
                YValueMembers = "ApprovedOrders"
            };

            chartResults.Series.Add(series);
            chartResults.DataSource = data;
            chartResults.DataBind();
        }
    }
}
