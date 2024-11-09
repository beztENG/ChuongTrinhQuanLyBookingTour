using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    public partial class UC_ManageTourBrand : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private string imagePath = Path.Combine(Application.StartupPath, @"Images\Company");
        private string selectedImageFileName = "";

        public UC_ManageTourBrand()
        {
            InitializeComponent();
            LoadTourBrands();
        }

        private void LoadTourBrands()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CompanyID, CompanyName, CompanyImage FROM CompanyTours";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTourBrands.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tour brands: " + ex.Message);
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO CompanyTours (CompanyName, CompanyImage) VALUES (@CompanyName, @CompanyImage)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    cmd.Parameters.AddWithValue("@CompanyImage", selectedImageFileName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tour brand added successfully.");
                    LoadTourBrands();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding tour brand: " + ex.Message);
                }
            }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Company Image",
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                if (pbCompanyImage.Image != null)
                {
                    pbCompanyImage.Image.Dispose();
                }

                using (Image originalImage = Image.FromFile(selectedImagePath))
                {
                    pbCompanyImage.Image = originalImage;
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTourBrands.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tour brand to update.");
                return;
            }

            int companyId = Convert.ToInt32(dgvTourBrands.SelectedRows[0].Cells["CompanyID"].Value);
            string companyName = txtCompanyName.Text;

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE CompanyTours SET CompanyName = @CompanyName, CompanyImage = @CompanyImage WHERE CompanyID = @CompanyID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    cmd.Parameters.AddWithValue("@CompanyImage", selectedImageFileName);
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tour brand updated successfully.");
                    LoadTourBrands();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating tour brand: " + ex.Message);
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTourBrands.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tour brand to delete.");
                return;
            }

            int companyId = Convert.ToInt32(dgvTourBrands.SelectedRows[0].Cells["CompanyID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM CompanyTours WHERE CompanyID = @CompanyID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tour brand deleted successfully.");
                    LoadTourBrands();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting tour brand: " + ex.Message);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }



        private void ClearFields()
        {
            txtCompanyName.Text = string.Empty;
            selectedImageFileName = string.Empty;
            pbCompanyImage.Image = null;
            dgvTourBrands.ClearSelection();
        }

        private void dgvTourBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCompanyName.Text = dgvTourBrands.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                selectedImageFileName = dgvTourBrands.Rows[e.RowIndex].Cells["CompanyImage"].Value.ToString();

                if (!string.IsNullOrEmpty(selectedImageFileName))
                {
                    string imagePath = Path.Combine(Application.StartupPath, @"Images\Company", selectedImageFileName);
                    if (File.Exists(imagePath))
                    {
                        pbCompanyImage.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pbCompanyImage.Image = null;
                    }
                }
            }
        }
    }
}
