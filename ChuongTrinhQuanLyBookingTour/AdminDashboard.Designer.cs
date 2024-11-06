namespace ChuongTrinhQuanLyBookingTour
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            btn = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_AddUsers1 = new All_Users_Control.UC_Admin.UC_AddUsers();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.White;
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(btn);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Dock = DockStyle.Left;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(231, 1102);
            guna2GradientPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 7;
            label1.Text = "Admin";
            // 
            // btn
            // 
            btn.BorderRadius = 18;
            btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn.CustomizableEdges = customizableEdges1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.FillColor = Color.FromArgb(192, 192, 255);
            btn.Font = new Font("Segoe UI", 9F);
            btn.ForeColor = Color.White;
            btn.Location = new Point(24, 155);
            btn.Name = "btn";
            btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn.Size = new Size(180, 116);
            btn.TabIndex = 3;
            btn.Text = "Button";
            btn.Click += btn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // uC_AddUsers1
            // 
            uC_AddUsers1.BackColor = Color.White;
            uC_AddUsers1.Location = new Point(279, 44);
            uC_AddUsers1.Name = "uC_AddUsers1";
            uC_AddUsers1.Size = new Size(1592, 1007);
            uC_AddUsers1.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.CustomizableEdges = customizableEdges5;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.FromArgb(192, 192, 255);
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(35, 35);
            btnExit.Location = new Point(1877, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExit.Size = new Size(59, 56);
            btnExit.TabIndex = 7;
            btnExit.Click += btnExit_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1942, 1102);
            Controls.Add(btnExit);
            Controls.Add(uC_AddUsers1);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_Users_Control.UC_Admin.UC_AddUsers uC_AddUsers1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}