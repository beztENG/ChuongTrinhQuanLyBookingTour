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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtHotelName = new Guna.UI2.WinForms.Guna2TextBox();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            txtRating = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            dgvHotelBrands = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvHotelBrands).BeginInit();
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
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Add Hotel";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.CustomizableEdges = customizableEdges7;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(260, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvHotelBrands
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHotelBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHotelBrands.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHotelBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHotelBrands.ColumnHeadersHeight = 4;
            dgvHotelBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHotelBrands.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHotelBrands.GridColor = Color.FromArgb(231, 229, 255);
            dgvHotelBrands.Location = new Point(400, 26);
            dgvHotelBrands.Name = "dgvHotelBrands";
            dgvHotelBrands.RowHeadersVisible = false;
            dgvHotelBrands.RowHeadersWidth = 51;
            dgvHotelBrands.Size = new Size(795, 324);
            dgvHotelBrands.TabIndex = 10;
            dgvHotelBrands.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHotelBrands.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHotelBrands.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHotelBrands.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHotelBrands.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHotelBrands.ThemeStyle.BackColor = Color.White;
            dgvHotelBrands.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHotelBrands.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHotelBrands.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHotelBrands.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvHotelBrands.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHotelBrands.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHotelBrands.ThemeStyle.HeaderStyle.Height = 29;
            dgvHotelBrands.ThemeStyle.ReadOnly = false;
            dgvHotelBrands.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHotelBrands.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHotelBrands.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHotelBrands.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHotelBrands.ThemeStyle.RowsStyle.Height = 29;
            dgvHotelBrands.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHotelBrands.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHotelBrands.CellContentClick += dgvHotelBrands_CellContentClick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ManageHotelBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(dgvHotelBrands);
            Controls.Add(btnSubmit);
            Controls.Add(txtRating);
            Controls.Add(label4);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtHotelName);
            Controls.Add(label1);
            Name = "UC_ManageHotelBrand";
            Size = new Size(1264, 610);
            ((System.ComponentModel.ISupportInitialize)dgvHotelBrands).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtHotelName;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtRating;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate; // Update Button
        private Guna.UI2.WinForms.Guna2DataGridView dgvHotelBrands; // DataGridView
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
