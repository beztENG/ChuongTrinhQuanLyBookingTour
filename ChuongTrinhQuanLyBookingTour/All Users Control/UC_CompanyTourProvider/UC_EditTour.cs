using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_CompanyTourProvider
{
    public partial class UC_EditTour : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int companyID;
        private int selectedTourID;
        private string selectedTourImageFileName;
        private readonly string imagePath = Path.Combine(Application.StartupPath, @"Images\Tour");

        public UC_EditTour()
        {
            InitializeComponent();
        }

        public void SetCompanyID(int companyID)
        {
            this.companyID = companyID;
            LoadTours();
        }

        public void LoadTours()
        {
            if (companyID == 0)
            {
                MessageBox.Show("CompanyID chưa có.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TourID, TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage " +
                               "FROM Tours WHERE companyID = @CompanyID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CompanyID", companyID);
                DataTable toursTable = new DataTable();
                adapter.Fill(toursTable);

                dataGridViewTours.DataSource = toursTable;
            }
        }

        private void dataGridViewTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTours.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                selectedTourID = Convert.ToInt32(dataGridViewTours.Rows[e.RowIndex].Cells["TourID"].Value);
                txtTourName.Text = dataGridViewTours.Rows[e.RowIndex].Cells["TourName"].Value.ToString();
                txtStarting.Text = dataGridViewTours.Rows[e.RowIndex].Cells["Starting"].Value.ToString();
                txtDestination.Text = dataGridViewTours.Rows[e.RowIndex].Cells["Destination"].Value.ToString();
                dateTimePickerStartingDate.Value = Convert.ToDateTime(dataGridViewTours.Rows[e.RowIndex].Cells["StartingDate"].Value);
                dateTimePickerReturnDate.Value = Convert.ToDateTime(dataGridViewTours.Rows[e.RowIndex].Cells["ReturnDate"].Value);
                txtDescription.Text = dataGridViewTours.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtCost.Text = dataGridViewTours.Rows[e.RowIndex].Cells["Cost"].Value.ToString();
                lblImagePath.Text = dataGridViewTours.Rows[e.RowIndex].Cells["TourImage"].Value.ToString();

                string tourImagePath = lblImagePath.Text;
                if (File.Exists(tourImagePath))
                {
                    pictureBoxTourImage.Image = Image.FromFile(tourImagePath);
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.companyID = GlobalUserInfo.CompanyID;
            string tourName = txtTourName.Text;
            string starting = txtStarting.Text;
            string destination = txtDestination.Text;
            DateTime startingDate = dateTimePickerStartingDate.Value;
            DateTime returnDate = dateTimePickerReturnDate.Value;
            string description = txtDescription.Text;
            decimal cost = decimal.Parse(txtCost.Text);
            string tourImageName = Path.GetFileName(lblImagePath.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tours SET TourName = @TourName, Starting = @Starting, Destination = @Destination, " +
                               "StartingDate = @StartingDate, ReturnDate = @ReturnDate, Description = @Description, Cost = @Cost, " +
                               "TourImage = @TourImage WHERE TourID = @TourID AND CompanyID = @CompanyID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TourName", tourName);
                command.Parameters.AddWithValue("@Starting", starting);
                command.Parameters.AddWithValue("@Destination", destination);
                command.Parameters.AddWithValue("@StartingDate", startingDate);
                command.Parameters.AddWithValue("@ReturnDate", returnDate);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@TourImage", tourImageName);
                command.Parameters.AddWithValue("@TourID", selectedTourID);
                command.Parameters.AddWithValue("@CompanyID", companyID);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Chi tiết chuyến đi được cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTours();
            }
        }

        private void btnSelectTourImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Tour Image",
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                if (pictureBoxTourImage.Image != null)
                {
                    pictureBoxTourImage.Image.Dispose();
                }

                using (Image originalImage = Image.FromFile(selectedImagePath))
                {
                    pictureBoxTourImage.Image = ImageHelper.ResizeImage(originalImage, 100, 100);
                }

                selectedTourImageFileName = Path.GetFileName(selectedImagePath);
                string destinationPath = Path.Combine(imagePath, selectedTourImageFileName);

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                try
                {
                    File.Copy(selectedImagePath, destinationPath, true);
                    lblImagePath.Text = destinationPath;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
