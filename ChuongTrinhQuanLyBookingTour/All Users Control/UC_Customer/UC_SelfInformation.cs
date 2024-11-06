using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.Helpers; 

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    public partial class UC_SelfInformation : UserControl
    {
        private string connectionString = DatabaseHelper.ConnectionString; 
        string imagePath = Path.Combine(Application.StartupPath, @"Images\User");
        string avatarFileName = "";

        public UC_SelfInformation()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            int userId = GlobalUserInfo.UserID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FullName, Email, Phone, Avatar FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    avatarFileName = reader["Avatar"].ToString();

                    string avatarPath = Path.Combine(imagePath, avatarFileName);
                    string defaultUserImage = Path.Combine(Application.StartupPath, @"Images\User", "DefaultUser.png");

                    if (File.Exists(avatarPath))
                    {
                        using (Image originalImage = Image.FromFile(avatarPath))
                        {
                            pictureBoxAvatar.Image = ImageHelper.ResizeImage(originalImage, 200, 200);
                        }
                    }
                    else
                    {
                        using (Image defaultImage = Image.FromFile(defaultUserImage))
                        {
                            pictureBoxAvatar.Image = ImageHelper.ResizeImage(defaultImage, 200, 200);
                        }
                    }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            int userId = GlobalUserInfo.UserID;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra mật khẩu cũ
                string query = "SELECT Password FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                object result = cmd.ExecuteScalar();
                if (result == null || result.ToString() != oldPassword)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }

                // Cập nhật mật khẩu mới
                query = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@UserID", userId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Password update failed.");
                }
            }
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            txtFullName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            btnChangeAvatar.Enabled = true;  
            btnSave.Enabled = true;  
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png",
                Title = "Select an Avatar"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = ofd.FileName;

                if (pictureBoxAvatar.Image != null)
                {
                    pictureBoxAvatar.Image.Dispose();
                }

                using (Image originalImage = Image.FromFile(selectedImagePath))
                {
                    pictureBoxAvatar.Image = ImageHelper.ResizeImage(originalImage, 200, 200);
                }

                avatarFileName = Path.GetFileName(selectedImagePath);
                string destinationPath = Path.Combine(imagePath, avatarFileName);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int userId = GlobalUserInfo.UserID;
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET FullName = @FullName, Email = @Email, Phone = @Phone, Avatar = @Avatar WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Avatar", avatarFileName);
                cmd.Parameters.AddWithValue("@UserID", userId);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Information updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }

        }
    }
}
