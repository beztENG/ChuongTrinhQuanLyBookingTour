namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    partial class UC_SelfInformation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnAdjust = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnChangeAvatar = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(778, 54);
            label1.Name = "label1";
            label1.Size = new Size(283, 35);
            label1.TabIndex = 2;
            label1.Text = "Thông tin cá nhân";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.ImageRotate = 0F;
            pictureBoxAvatar.InitialImage = null;
            pictureBoxAvatar.Location = new Point(38, 104);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBoxAvatar.Size = new Size(194, 181);
            pictureBoxAvatar.TabIndex = 3;
            pictureBoxAvatar.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 425);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 504);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 575);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(18, 448);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 527);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(18, 598);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 27);
            txtPhone.TabIndex = 9;
            // 
            // btnAdjust
            // 
            btnAdjust.BorderRadius = 18;
            btnAdjust.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnAdjust.BorderThickness = 1;
            btnAdjust.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnAdjust.CheckedState.ForeColor = Color.White;
            btnAdjust.CustomizableEdges = customizableEdges2;
            btnAdjust.DisabledState.BorderColor = Color.DarkGray;
            btnAdjust.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdjust.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdjust.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdjust.FillColor = Color.White;
            btnAdjust.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAdjust.ForeColor = Color.Black;
            btnAdjust.Location = new Point(18, 672);
            btnAdjust.Name = "btnAdjust";
            btnAdjust.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdjust.Size = new Size(105, 56);
            btnAdjust.TabIndex = 25;
            btnAdjust.Text = "Chỉnh sửa";
            btnAdjust.Click += btnAdjust_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // btnChangeAvatar
            // 
            btnChangeAvatar.BorderRadius = 18;
            btnChangeAvatar.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnChangeAvatar.BorderThickness = 1;
            btnChangeAvatar.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnChangeAvatar.CheckedState.ForeColor = Color.White;
            btnChangeAvatar.CustomizableEdges = customizableEdges6;
            btnChangeAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnChangeAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChangeAvatar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChangeAvatar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChangeAvatar.FillColor = Color.White;
            btnChangeAvatar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnChangeAvatar.ForeColor = Color.Black;
            btnChangeAvatar.Location = new Point(83, 317);
            btnChangeAvatar.Name = "btnChangeAvatar";
            btnChangeAvatar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnChangeAvatar.Size = new Size(105, 56);
            btnChangeAvatar.TabIndex = 27;
            btnChangeAvatar.Text = "Chọn ảnh";
            btnChangeAvatar.Click += btnChangeAvatar_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 18;
            btnSave.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnSave.BorderThickness = 1;
            btnSave.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnSave.CheckedState.ForeColor = Color.White;
            btnSave.CustomizableEdges = customizableEdges4;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(143, 672);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnSave.Size = new Size(105, 56);
            btnSave.TabIndex = 28;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // UC_SelfInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(btnChangeAvatar);
            Controls.Add(btnAdjust);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(label1);
            Name = "UC_SelfInformation";
            Size = new Size(1882, 852);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnAdjust;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnChangeAvatar;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
