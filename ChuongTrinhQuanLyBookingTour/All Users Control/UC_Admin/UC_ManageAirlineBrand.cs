using ChuongTrinhQuanLyBookingTour.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class UC_ManageAirlineBrand : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private string imagePath = Path.Combine(Application.StartupPath, @"Images\Airlines");
        private string selectedImageFileName = "";

        public UC_ManageAirlineBrand()
        {
            InitializeComponent();
            LoadAirlines();
        }

        private void LoadAirlines()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AirlineID, AirlineName, AirlineImage FROM Airlines";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAirlines.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading airlines: " + ex.Message);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string airlineName = txtAirlineName.Text;

            if (string.IsNullOrEmpty(airlineName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Airlines (AirlineName, AirlineImage) VALUES (@AirlineName, @AirlineImage)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AirlineName", airlineName);
                    cmd.Parameters.AddWithValue("@AirlineImage", selectedImageFileName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Airline added successfully.");
                    LoadAirlines();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding airline: " + ex.Message);
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Airline Image",
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                if (pbAirlineImage.Image != null)
                {
                    pbAirlineImage.Image.Dispose();
                }

                using (Image originalImage = Image.FromFile(selectedImagePath))
                {
                    pbAirlineImage.Image = originalImage;
                }

                selectedImageFileName = Path.GetFileName(selectedImagePath);
                string destinationPath = Path.Combine(imagePath, selectedImageFileName);

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                try
                {
                    File.Copy(selectedImagePath, destinationPath, true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error copying the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAirlines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an airline to update.");
                return;
            }

            int airlineID = Convert.ToInt32(dgvAirlines.SelectedRows[0].Cells["AirlineID"].Value);
            string airlineName = txtAirlineName.Text;

            if (string.IsNullOrEmpty(airlineName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Airlines SET AirlineName = @AirlineName, AirlineImage = @AirlineImage WHERE AirlineID = @AirlineID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AirlineName", airlineName);
                    cmd.Parameters.AddWithValue("@AirlineImage", selectedImageFileName);
                    cmd.Parameters.AddWithValue("@AirlineID", airlineID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Airline updated successfully.");
                    LoadAirlines();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating airline: " + ex.Message);
                }
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (dgvAirlines.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Please select an airline to delete.");
        //        return;
        //    }

        //    int airlineID = Convert.ToInt32(dgvAirlines.SelectedRows[0].Cells["AirlineID"].Value);

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "DELETE FROM Airlines WHERE AirlineID = @AirlineID";
        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@AirlineID", airlineID);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Airline deleted successfully.");
        //            LoadAirlines();
        //            ClearFields();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error deleting airline: " + ex.Message);
        //        }
        //    }
        //}

        private void ClearFields()
        {
            txtAirlineName.Text = string.Empty;
            selectedImageFileName = string.Empty;
            pbAirlineImage.Image = null;
            dgvAirlines.ClearSelection();
        }

        private void dgvAirlines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAirlineName.Text = dgvAirlines.Rows[e.RowIndex].Cells["AirlineName"].Value.ToString();
                selectedImageFileName = dgvAirlines.Rows[e.RowIndex].Cells["AirlineImage"].Value.ToString();

                if (!string.IsNullOrEmpty(selectedImageFileName))
                {
                    string fullImagePath = Path.Combine(imagePath, selectedImageFileName);
                    if (File.Exists(fullImagePath))
                    {
                        pbAirlineImage.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        pbAirlineImage.Image = null;
                    }
                }
            }
        }
    }
}
