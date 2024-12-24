using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Register : Form
    {
        private string connectionString = DatabaseHelper.ConnectionString;
        private string imagePath = Path.Combine(Application.StartupPath, @"Images\User");
        private string selectedAvatarFileName = "";


        public Register()
        {

            InitializeComponent();
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Avatar",
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string selectedImagePath = openFileDialog.FileName;

                if (pictureBoxAvatar.Image != null)
                {
                    pictureBoxAvatar.Image.Dispose();
                }

                using (Image originalImage = Image.FromFile(selectedImagePath))
                {
                    pictureBoxAvatar.Image = ImageHelper.ResizeImage(originalImage, 200, 200);
                }


                selectedAvatarFileName = Path.GetFileName(selectedImagePath);
                string destinationPath = Path.Combine(imagePath, selectedAvatarFileName);


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
                    MessageBox.Show($"Error copying the avatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string role;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password are required.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role) VALUES (@Username, @Password, @FullName, @Email, @Phone, @Avatar, @Role)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Avatar", selectedAvatarFileName);
                    command.Parameters.AddWithValue("@Role", "Customer");

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Close();
                        Form1 loginForm = new Form1();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
