using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;
namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_TourProvider
{
    public partial class UC_AddNewTour : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private int providerID;
        private string selectedTourImageFileName; 
        private readonly string imagePath = Path.Combine(Application.StartupPath, @"Images\Tour");

        public UC_AddNewTour()
        {
            InitializeComponent();
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
                    MessageBox.Show($"Error copying the tour image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveTour_Click(object sender, EventArgs e)
        {
            this.providerID = GlobalUserInfo.ProviderID;
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
                string query = "INSERT INTO Tours (TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage, ProviderID) " +
                               "VALUES (@TourName, @Starting, @Destination, @StartingDate, @ReturnDate, @Description, @Cost, @TourImage, @ProviderID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TourName", tourName);
                command.Parameters.AddWithValue("@Starting", starting);
                command.Parameters.AddWithValue("@Destination", destination);
                command.Parameters.AddWithValue("@StartingDate", startingDate);
                command.Parameters.AddWithValue("@ReturnDate", returnDate);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@TourImage", tourImageName);
                command.Parameters.AddWithValue("@ProviderID", providerID);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("New tour added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
