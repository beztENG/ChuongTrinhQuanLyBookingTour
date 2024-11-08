using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Xml.Linq;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class UC_ManageHotelBrand
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtHotelName = new Guna.UI2.WinForms.Guna2TextBox();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            txtRating = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // txtHotelName
            // 
            txtHotelName.CustomizableEdges = customizableEdges1;
            txtHotelName.DefaultText = "";
            txtHotelName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHotelName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHotelName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.Font = new Font("Segoe UI", 9F);
            txtHotelName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.Location = new Point(150, 50);
            txtHotelName.Margin = new Padding(3, 4, 3, 4);
            txtHotelName.Name = "txtHotelName";
            txtHotelName.PasswordChar = '\0';
            txtHotelName.PlaceholderText = "Enter hotel name";
            txtHotelName.SelectedText = "";
            txtHotelName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtHotelName.Size = new Size(200, 22);
            txtHotelName.TabIndex = 0;
            // 
            // txtLocation
            // 
            txtLocation.CustomizableEdges = customizableEdges3;
            txtLocation.DefaultText = "";
            txtLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Font = new Font("Segoe UI", 9F);
            txtLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Location = new Point(150, 137);
            txtLocation.Margin = new Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '\0';
            txtLocation.PlaceholderText = "Enter location";
            txtLocation.SelectedText = "";
            txtLocation.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLocation.Size = new Size(200, 22);
            txtLocation.TabIndex = 4;
            // 
            // txtRating
            // 
            txtRating.CustomizableEdges = customizableEdges5;
            txtRating.DefaultText = "";
            txtRating.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRating.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRating.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRating.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRating.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRating.Font = new Font("Segoe UI", 9F);
            txtRating.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRating.Location = new Point(150, 227);
            txtRating.Margin = new Padding(3, 4, 3, 4);
            txtRating.Name = "txtRating";
            txtRating.PasswordChar = '\0';
            txtRating.PlaceholderText = "Enter rating (1-5)";
            txtRating.SelectedText = "";
            txtRating.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtRating.Size = new Size(200, 22);
            txtRating.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Hotel Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 203);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 7;
            label4.Text = "Rating:";
            // 
            // btnSubmit
            // 
            btnSubmit.CustomizableEdges = customizableEdges7;
            btnSubmit.Font = new Font("Segoe UI", 9F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(150, 307);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSubmit.Size = new Size(200, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Add Hotel";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ManageHotelBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSubmit);
            Controls.Add(txtRating);
            Controls.Add(label4);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtHotelName);
            Controls.Add(label1);
            Name = "UC_ManageHotelBrand";
            Size = new Size(1083, 610);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtHotelName;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtRating;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
