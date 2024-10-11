using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using Guna.UI2.WinForms;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Register : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=TourBookingDB;Integrated Security=True";
        private string selectedAvatar = "";
        

        public Register()
        {
            
        InitializeComponent();
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an avatar
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Avatar";
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in the PictureBox
                selectedAvatar = Path.GetFileName(openFileDialog.FileName);
                pictureBoxAvatar.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get input values from the form
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

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

                    // Insert user information into the database
                    string query = "INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar) VALUES (@Username, @Password, @FullName, @Email, @Phone, @Avatar)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Avatar", selectedAvatar);  // Store the selected avatar's filename

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Close();  // Close the registration form
                        Form1 loginForm = new Form1();  // Redirect to login form
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

    }
}
