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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_AddUsers1 = new All_Users_Control.UC_Admin.UC_AddUsers();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.CustomizableEdges = customizableEdges1;
            btnAddUser.DisabledState.BorderColor = Color.DarkGray;
            btnAddUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddUser.Font = new Font("Segoe UI", 9F);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(31, 40);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddUser.Size = new Size(225, 56);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // uC_AddUsers1
            // 
            uC_AddUsers1.Location = new Point(31, 102);
            uC_AddUsers1.Name = "uC_AddUsers1";
            uC_AddUsers1.Size = new Size(1155, 665);
            uC_AddUsers1.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 814);
            Controls.Add(uC_AddUsers1);
            Controls.Add(btnAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_Users_Control.UC_Admin.UC_AddUsers uC_AddUsers1;
    }
}