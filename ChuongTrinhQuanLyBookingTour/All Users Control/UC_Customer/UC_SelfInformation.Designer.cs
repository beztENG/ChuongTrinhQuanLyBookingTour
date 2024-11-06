namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    partial class UC_SelfInformation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new Label();
            this.guna2GroupBoxPersonalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnChangeAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBoxPassword = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();

            // 
            // label1 (Title)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.FromArgb(33, 150, 243);
            this.label1.Location = new Point(100, 30);  // Tiêu đề nằm ở vị trí ban đầu
            this.label1.Name = "label1";
            this.label1.Size = new Size(300, 45);
            this.label1.Text = "Thông tin cá nhân";
            this.label1.TabIndex = 0;

            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.ImageRotate = 0F;
            this.pictureBoxAvatar.Location = new Point(200, 90); // Đặt ảnh đại diện ngay dưới tiêu đề
            this.pictureBoxAvatar.Size = new Size(150, 150); // Phóng to ảnh đại diện
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxAvatar.ShadowDecoration.Color = Color.Gray;
            this.pictureBoxAvatar.ShadowDecoration.Depth = 20;
            this.pictureBoxAvatar.ShadowDecoration.Enabled = true;
            this.pictureBoxAvatar.TabIndex = 5;

            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BorderRadius = 15;
            this.btnChangeAvatar.FillColor = Color.FromArgb(33, 150, 243);
            this.btnChangeAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnChangeAvatar.ForeColor = Color.White;
            this.btnChangeAvatar.Location = new Point(210, 250); // Nút đặt ngay dưới ảnh đại diện
            this.btnChangeAvatar.Size = new Size(120, 40);
            this.btnChangeAvatar.Text = "Thay đổi ảnh";
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);

            // 
            // guna2GroupBoxPersonalInfo
            // 
            this.guna2GroupBoxPersonalInfo.BorderRadius = 10;
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.txtFullName);
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.txtEmail);
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.txtPhone);
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.btnSave);
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.pictureBoxAvatar);
            this.guna2GroupBoxPersonalInfo.Controls.Add(this.btnChangeAvatar);
            this.guna2GroupBoxPersonalInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.guna2GroupBoxPersonalInfo.ForeColor = Color.Black;
            this.guna2GroupBoxPersonalInfo.Location = new Point(50, 100);
            this.guna2GroupBoxPersonalInfo.Name = "guna2GroupBoxPersonalInfo";
            this.guna2GroupBoxPersonalInfo.Size = new Size(600, 600); // Đã giảm chiều cao để phù hợp
            this.guna2GroupBoxPersonalInfo.TabIndex = 1;
            this.guna2GroupBoxPersonalInfo.Text = "Thông tin cá nhân";

            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 8;
            this.txtFullName.Font = new Font("Segoe UI", 12F);
            this.txtFullName.PlaceholderText = "Họ tên";
            this.txtFullName.Location = new Point(50, 310); // Đặt Họ tên dưới nút thay đổi ảnh
            this.txtFullName.Size = new Size(400, 40);
            this.txtFullName.TabIndex = 2;

            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Font = new Font("Segoe UI", 12F);
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Location = new Point(50, 360); // Đặt Email dưới Họ tên
            this.txtEmail.Size = new Size(400, 40);
            this.txtEmail.TabIndex = 3;

            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Font = new Font("Segoe UI", 12F);
            this.txtPhone.PlaceholderText = "Số điện thoại";
            this.txtPhone.Location = new Point(50, 410); // Đặt Số điện thoại dưới Email
            this.txtPhone.Size = new Size(400, 40);
            this.txtPhone.TabIndex = 4;

            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = Color.FromArgb(33, 150, 243);
            this.btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(200, 470); // Đặt nút Lưu ở dưới cùng
            this.btnSave.Size = new Size(150, 45);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // guna2GroupBoxPassword
            // 
            this.guna2GroupBoxPassword.BorderRadius = 10;
            this.guna2GroupBoxPassword.Controls.Add(this.txtOldPassword);
            this.guna2GroupBoxPassword.Controls.Add(this.txtNewPassword);
            this.guna2GroupBoxPassword.Controls.Add(this.txtConfirmPassword);
            this.guna2GroupBoxPassword.Controls.Add(this.btnChangePassword);
            this.guna2GroupBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.guna2GroupBoxPassword.ForeColor = Color.Black;
            this.guna2GroupBoxPassword.Location = new Point(700, 100);
            this.guna2GroupBoxPassword.Size = new Size(600, 400);
            this.guna2GroupBoxPassword.TabIndex = 6;
            this.guna2GroupBoxPassword.Text = "Thay đổi mật khẩu";

            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BorderRadius = 8;
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.PlaceholderText = "Mật khẩu cũ";
            this.txtOldPassword.Location = new Point(50, 80);
            this.txtOldPassword.Size = new Size(400, 40);
            this.txtOldPassword.TabIndex = 7;

            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 8;
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "Mật khẩu mới";
            this.txtNewPassword.Location = new Point(50, 140);
            this.txtNewPassword.Size = new Size(400, 40);
            this.txtNewPassword.TabIndex = 8;

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 8;
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txtConfirmPassword.Location = new Point(50, 200);
            this.txtConfirmPassword.Size = new Size(400, 40);
            this.txtConfirmPassword.TabIndex = 9;

            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BorderRadius = 10;
            this.btnChangePassword.FillColor = Color.FromArgb(33, 150, 243);
            this.btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnChangePassword.ForeColor = Color.White;
            this.btnChangePassword.Location = new Point(50, 260);
            this.btnChangePassword.Size = new Size(200, 45);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // 
            // UC_SelfInformation
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBoxPersonalInfo);
            this.Controls.Add(this.guna2GroupBoxPassword);
            this.Name = "UC_SelfInformation";
            this.Size = new Size(1350, 700);
            this.guna2GroupBoxPersonalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.guna2GroupBoxPassword.ResumeLayout(false);
        }

        private Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxPersonalInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private Guna.UI2.WinForms.Guna2Button btnChangeAvatar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
    }
}
