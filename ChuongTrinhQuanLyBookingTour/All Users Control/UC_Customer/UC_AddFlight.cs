using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;
using ChuongTrinhQuanLyBookingTour.Models;

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
            string query = "SELECT DISTINCT a.AirlineID, a.AirlineImage FROM Flights f JOIN Airlines a ON f.AirlineID = a.AirlineID";
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
            string selectedAirline = ((DataRowView)cmbAirline.SelectedItem)?["Airline"].ToString();
            string selectedDeparture = cmbDeparture.SelectedItem?.ToString();
            string selectedArrival = cmbArrival.SelectedItem?.ToString();
            DateTime departureDate = dtpDepartureDate.Value; // Lấy ngày đi từ DateTimePicker
            Console.WriteLine(departureDate);
            if (string.IsNullOrEmpty(selectedAirline) ||
                string.IsNullOrEmpty(selectedDeparture) ||
                string.IsNullOrEmpty(selectedArrival))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ các trường (Hãng hàng không, Nơi khởi hành, Nơi đến) trước khi tìm kiếm.");
                return;
            }

            if (chkRoundTrip.Checked)
            {
                // Người dùng chọn khứ hồi
                DateTime returnDate = dtpReturnDate.Value;

                // Nơi khởi hành của chuyến bay về là nơi đến của chuyến đi
                string returnDeparture = selectedArrival;

                // Nơi đến của chuyến bay về là nơi khởi hành của chuyến đi
                string returnArrival = selectedDeparture;

                // Tìm kiếm chuyến bay đi và về
                LoadRoundTripFlights(selectedAirline, selectedDeparture, selectedArrival, departureDate, returnDate, returnDeparture, returnArrival);
            }
            else
            {
                // Người dùng chọn chuyến đi một chiều
                LoadFlights(selectedAirline, selectedDeparture, selectedArrival, departureDate);
            }
        }

        private void LoadFlights(string airline, string departure, string arrival, DateTime departureDate)
        {
            string query = @"SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime 
                     FROM Flights 
                     WHERE Airline = @Airline 
                     AND Departure = @Departure 
                     AND Arrival = @Arrival
                     AND DepartureDate = @DepartureDate
                     AND Status = 1"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Airline", airline);
                cmd.Parameters.AddWithValue("@Departure", departure);
                cmd.Parameters.AddWithValue("@Arrival", arrival);
                cmd.Parameters.AddWithValue("@DepartureDate", departureDate.ToString("yyyy-MM-dd"));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No available flights found.");
                }
                else
                {
                    dgvFlights.DataSource = dt;
                }

                dgvFlights.AutoResizeColumns();
            }
        }

        private void LoadRoundTripFlights(string airline, string departure, string arrival, DateTime departureDate, DateTime returnDate, string returnDeparture, string returnArrival)
        {
            string queryOutbound = @"SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime 
                             FROM Flights 
                             WHERE Airline = @Airline 
                             AND Departure = @Departure 
                             AND Arrival = @Arrival
                             AND DepartureDate = @DepartureDate
                             AND Status = 1"; 

            string queryReturn = @"SELECT FlightID, Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime 
                           FROM Flights 
                           WHERE Airline = @Airline 
                           AND Departure = @ReturnDeparture 
                           AND Arrival = @ReturnArrival 
                           AND DepartureDate = @ReturnDate
                           AND Status = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdOutbound = new SqlCommand(queryOutbound, conn);
                SqlCommand cmdReturn = new SqlCommand(queryReturn, conn);

                cmdOutbound.Parameters.AddWithValue("@Airline", airline);
                cmdOutbound.Parameters.AddWithValue("@Departure", departure);
                cmdOutbound.Parameters.AddWithValue("@Arrival", arrival);
                cmdOutbound.Parameters.AddWithValue("@DepartureDate", departureDate.ToString("yyyy-MM-dd"));

                cmdReturn.Parameters.AddWithValue("@Airline", airline);
                cmdReturn.Parameters.AddWithValue("@ReturnDeparture", returnDeparture);
                cmdReturn.Parameters.AddWithValue("@ReturnArrival", returnArrival);
                cmdReturn.Parameters.AddWithValue("@ReturnDate", returnDate.ToString("yyyy-MM-dd"));

                SqlDataAdapter daOutbound = new SqlDataAdapter(cmdOutbound);
                SqlDataAdapter daReturn = new SqlDataAdapter(cmdReturn);

                DataTable dtOutbound = new DataTable();
                DataTable dtReturn = new DataTable();

                daOutbound.Fill(dtOutbound);
                daReturn.Fill(dtReturn);

                if (dtOutbound.Rows.Count == 0 || dtReturn.Rows.Count == 0)
                {
                    MessageBox.Show("No suitable flights found for the round trip.");
                }
                else
                {
                    dgvFlights.DataSource = dtOutbound;
                    dgvReturnFlights.DataSource = dtReturn;
                }
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
            cmbArrival.Items.Add("Phu Quoc");
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay để đặt vé.");
                return;
            }

            DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
            int flightID = (int)selectedRow.Cells["FlightID"].Value;
            string airline = selectedRow.Cells["Airline"].Value.ToString();
            DateTime departureDate = (DateTime)selectedRow.Cells["DepartureDate"].Value;
            decimal price = GetFlightCost(flightID);

            int userID = GlobalUserInfo.UserID;

            // Đặt chỗ cho chuyến đi
            BookingInfo bookingInfo = new BookingInfo
            {
                UserID = userID,
                FlightID = flightID,
                Airline = airline,
                DepartureDate = departureDate,
                Price = price,
                BookingType = "Flight"
            };

            if (chkRoundTrip.Checked)
            {
                // Người dùng chọn khứ hồi, xử lý tiếp chuyến bay về
                // Yêu cầu người dùng chọn chuyến bay về từ DataGridView khác hoặc thông qua tìm kiếm

                // Giả sử có một DataGridView khác tên là dgvReturnFlights cho chuyến bay về
                if (dgvReturnFlights.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chuyến bay về để hoàn tất đặt vé khứ hồi.");
                    return;
                }

                // Lấy thông tin chuyến về
                DataGridViewRow selectedReturnRow = dgvReturnFlights.SelectedRows[0];
                int returnFlightID = (int)selectedReturnRow.Cells["FlightID"].Value;
                string returnAirline = selectedReturnRow.Cells["Airline"].Value.ToString();
                DateTime returnDate = (DateTime)selectedReturnRow.Cells["DepartureDate"].Value;
                decimal returnPrice = GetFlightCost(returnFlightID);

                // Tạo đối tượng BookingInfo cho chuyến về
                BookingInfo returnBookingInfo = new BookingInfo
                {
                    UserID = userID,
                    FlightID = returnFlightID,
                    Airline = returnAirline,
                    DepartureDate = returnDate,
                    Price = returnPrice,
                    BookingType = "Flight"
                };

                // Gửi thông tin cả chuyến đi và chuyến về đến trang thanh toán
                Payment paymentForm1 = new Payment(bookingInfo);
                paymentForm1.Show();
                Payment paymentForm2 = new Payment(returnBookingInfo);
                paymentForm2.Show();
            }
            else
            {
                // Nếu không phải khứ hồi, chỉ gửi chuyến đi
                Payment paymentForm3 = new Payment(bookingInfo);
                paymentForm3.Show();
            }
        }

        private decimal GetFlightCost(int flightID)
        {
            decimal cost = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Cost FROM Flights WHERE FlightID = @flightID", conn);
                cmd.Parameters.AddWithValue("@flightID", flightID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cost = Convert.ToDecimal(reader["Cost"]);
                }
                reader.Close();
            }

            return cost;
        }

        private void UC_AddFlight_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void chkRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn DateTimePicker để chọn ngày về
            bool isRoundTrip = chkRoundTrip.Checked;
            lblReturnDate.Visible = isRoundTrip;
            dtpReturnDate.Visible = isRoundTrip;
            dgvReturnFlights.Visible = isRoundTrip;
            label5.Visible = isRoundTrip;
        }

    }
}
