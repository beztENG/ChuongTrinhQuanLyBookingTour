using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class UC_ManageTourBrand : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2DataGridView dgvTourBrands;
        private Guna2TextBox txtCompanyName;
        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnClear;
        private Guna2Button btnSelectImage;
        private Guna2PictureBox pbCompanyImage;
        private Label lblCompanyName;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvTourBrands = new Guna2DataGridView();
            lblCompanyName = new Label();
            txtCompanyName = new Guna2TextBox();
            btnAdd = new Guna2Button();
            btnUpdate = new Guna2Button();
            btnDelete = new Guna2Button();
            btnClear = new Guna2Button();
            pbCompanyImage = new Guna2PictureBox();
            btnSelectImage = new Guna2Button();
            guna2Elipse1 = new Guna2Elipse(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTourBrands).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCompanyImage).BeginInit();
            SuspendLayout();
            // 
            // dgvTourBrands
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTourBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTourBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTourBrands.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTourBrands.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTourBrands.GridColor = Color.FromArgb(231, 229, 255);
            dgvTourBrands.Location = new Point(94, 105);
            dgvTourBrands.MultiSelect = false;
            dgvTourBrands.Name = "dgvTourBrands";
            dgvTourBrands.RowHeadersVisible = false;
            dgvTourBrands.RowHeadersWidth = 51;
            dgvTourBrands.Size = new Size(1175, 300);
            dgvTourBrands.TabIndex = 0;
            dgvTourBrands.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTourBrands.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTourBrands.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTourBrands.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTourBrands.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTourBrands.ThemeStyle.BackColor = Color.White;
            dgvTourBrands.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTourBrands.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTourBrands.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTourBrands.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTourBrands.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTourBrands.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTourBrands.ThemeStyle.HeaderStyle.Height = 29;
            dgvTourBrands.ThemeStyle.ReadOnly = false;
            dgvTourBrands.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTourBrands.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTourBrands.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTourBrands.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTourBrands.ThemeStyle.RowsStyle.Height = 29;
            dgvTourBrands.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTourBrands.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTourBrands.CellContentClick += dgvTourBrands_CellContentClick;
            // 
            // lblCompanyName
            // 
            lblCompanyName.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(225, 475);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(100, 30);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BorderRadius = 5;
            txtCompanyName.CustomizableEdges = customizableEdges1;
            txtCompanyName.DefaultText = "";
            txtCompanyName.Font = new Font("Montserrat", 10.2F);
            txtCompanyName.Location = new Point(359, 469);
            txtCompanyName.Margin = new Padding(4, 5, 4, 5);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PasswordChar = '\0';
            txtCompanyName.PlaceholderText = "Enter company name";
            txtCompanyName.SelectedText = "";
            txtCompanyName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCompanyName.Size = new Size(275, 36);
            txtCompanyName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.FillColor = Color.DarkTurquoise;
            btnAdd.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(387, 617);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(132, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 10;
            btnUpdate.CustomizableEdges = customizableEdges5;
            btnUpdate.FillColor = Color.DarkTurquoise;
            btnUpdate.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(540, 617);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdate.Size = new Size(132, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 10;
            btnDelete.CustomizableEdges = customizableEdges7;
            btnDelete.FillColor = Color.Red;
            btnDelete.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(694, 617);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDelete.Size = new Size(132, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BorderRadius = 10;
            btnClear.CustomizableEdges = customizableEdges9;
            btnClear.FillColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(845, 617);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnClear.Size = new Size(132, 46);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.Click += BtnClear_Click;
            // 
            // pbCompanyImage
            // 
            pbCompanyImage.CustomizableEdges = customizableEdges11;
            pbCompanyImage.ImageRotate = 0F;
            pbCompanyImage.Location = new Point(956, 432);
            pbCompanyImage.Name = "pbCompanyImage";
            pbCompanyImage.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pbCompanyImage.Size = new Size(100, 100);
            pbCompanyImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCompanyImage.TabIndex = 5;
            pbCompanyImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.BorderRadius = 10;
            btnSelectImage.CustomizableEdges = customizableEdges13;
            btnSelectImage.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.Location = new Point(956, 538);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSelectImage.Size = new Size(100, 30);
            btnSelectImage.TabIndex = 6;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.Click += BtnSelectImage_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 41);
            label1.Name = "label1";
            label1.Size = new Size(565, 39);
            label1.TabIndex = 9;
            label1.Text = "ADD TOUR PROVIDER INFORMATION";
            // 
            // UC_ManageTourBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dgvTourBrands);
            Controls.Add(lblCompanyName);
            Controls.Add(txtCompanyName);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(pbCompanyImage);
            Controls.Add(btnSelectImage);
            Name = "UC_ManageTourBrand";
            Size = new Size(1372, 703);
            ((System.ComponentModel.ISupportInitialize)dgvTourBrands).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCompanyImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2Elipse guna2Elipse1;
        private Label label1;
    }
}
