namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class UC_AddUsers
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
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Location = new Point(110, 47);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 22);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.CustomizableEdges = customizableEdges1;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F);
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(188, 37);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUserName.Size = new Size(286, 42);
            txtUserName.TabIndex = 1;
            // 
            // UC_AddUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Name = "UC_AddUsers";
            Size = new Size(924, 532);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
    }
}
