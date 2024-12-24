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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHotelBrands).BeginInit();
            SuspendLayout();
            // 
            // txtHotelName
            // 
            txtHotelName.BorderRadius = 5;
            txtHotelName.CustomizableEdges = customizableEdges17;
            txtHotelName.DefaultText = "";
            txtHotelName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHotelName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHotelName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.Font = new Font("Montserrat", 10.2F);
            txtHotelName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.Location = new Point(130, 135);
            txtHotelName.Margin = new Padding(4, 5, 4, 5);
            txtHotelName.Name = "txtHotelName";
            txtHotelName.PasswordChar = '\0';
            txtHotelName.PlaceholderText = "Enter hotel name";
            txtHotelName.SelectedText = "";
            txtHotelName.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtHotelName.Size = new Size(275, 34);
            txtHotelName.TabIndex = 0;
            // 
            // txtLocation
            // 
            txtLocation.BorderRadius = 5;
            txtLocation.CustomizableEdges = customizableEdges19;
            txtLocation.DefaultText = "";
            txtLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Font = new Font("Montserrat", 10.2F);
            txtLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLocation.Location = new Point(488, 135);
            txtLocation.Margin = new Padding(4, 5, 4, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '\0';
            txtLocation.PlaceholderText = "Enter location";
            txtLocation.SelectedText = "";
            txtLocation.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtLocation.Size = new Size(275, 34);
            txtLocation.TabIndex = 4;
            // 
            // txtRating
            // 
            txtRating.BorderRadius = 5;
            txtRating.CustomizableEdges = customizableEdges21;
            txtRating.DefaultText = "";
            txtRating.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRating.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRating.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRating.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRating.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRating.Font = new Font("Montserrat", 10.2F);
            txtRating.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRating.Location = new Point(846, 135);
            txtRating.Margin = new Padding(4, 5, 4, 5);
            txtRating.Name = "txtRating";
            txtRating.PasswordChar = '\0';
            txtRating.PlaceholderText = "Enter rating (1-5)";
            txtRating.SelectedText = "";
            txtRating.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtRating.Size = new Size(275, 34);
            txtRating.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            label1.Location = new Point(130, 106);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 1;
            label1.Text = "Hotel Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            label3.Location = new Point(488, 106);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            label4.Location = new Point(846, 106);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 7;
            label4.Text = "Rating:";
            label4.Click += label4_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges23;
            btnSubmit.FillColor = Color.DarkTurquoise;
            btnSubmit.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(467, 519);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnSubmit.Size = new Size(142, 44);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Add Hotel";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 5;

            btnUpdate.FillColor = Color.DarkTurquoise;
            btnUpdate.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(641, 519);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvHotelBrands
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvHotelBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvHotelBrands.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvHotelBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvHotelBrands.ColumnHeadersHeight = 29;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvHotelBrands.DefaultCellStyle = dataGridViewCellStyle9;
            dgvHotelBrands.GridColor = Color.FromArgb(231, 229, 255);
            dgvHotelBrands.Location = new Point(130, 177);
            dgvHotelBrands.Name = "dgvHotelBrands";
            dgvHotelBrands.RowHeadersVisible = false;
            dgvHotelBrands.RowHeadersWidth = 51;
            dgvHotelBrands.Size = new Size(991, 316);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 49);
            label2.Name = "label2";
            label2.Size = new Size(581, 39);
            label2.TabIndex = 11;
            label2.Text = "ADD HOTEL PROVIDER INFORMATION";
            // 
            // UC_ManageHotelBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
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
        private Label label2;
    }
}
