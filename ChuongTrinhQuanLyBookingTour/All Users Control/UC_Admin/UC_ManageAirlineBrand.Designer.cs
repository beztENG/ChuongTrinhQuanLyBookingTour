namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class UC_ManageAirlineBrand
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtAirlineName;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSelectImage;
        private Guna.UI2.WinForms.Guna2PictureBox pbAirlineImage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAirlines;
        private Label label1;
        private Label label4;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtAirlineName = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnSelectImage = new Guna.UI2.WinForms.Guna2Button();
            pbAirlineImage = new Guna.UI2.WinForms.Guna2PictureBox();
            dgvAirlines = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            label4 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pbAirlineImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAirlines).BeginInit();
            SuspendLayout();
            // 
            // txtAirlineName
            // 
            txtAirlineName.CustomizableEdges = customizableEdges1;
            txtAirlineName.DefaultText = "";
            txtAirlineName.Font = new Font("Segoe UI", 9F);
            txtAirlineName.Location = new Point(150, 50);
            txtAirlineName.Margin = new Padding(3, 4, 3, 4);
            txtAirlineName.Name = "txtAirlineName";
            txtAirlineName.PasswordChar = '\0';
            txtAirlineName.PlaceholderText = "Enter airline name";
            txtAirlineName.SelectedText = "";
            txtAirlineName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtAirlineName.Size = new Size(200, 22);
            txtAirlineName.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.CustomizableEdges = customizableEdges3;
            btnSubmit.Font = new Font("Segoe UI", 9F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(150, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Add Airline";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.CustomizableEdges = customizableEdges5;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(270, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Airline";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSelectImage
            // 
            btnSelectImage.CustomizableEdges = customizableEdges7;
            btnSelectImage.Font = new Font("Segoe UI", 9F);
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.Location = new Point(150, 280);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSelectImage.Size = new Size(200, 30);
            btnSelectImage.TabIndex = 5;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // pbAirlineImage
            // 
            pbAirlineImage.BorderStyle = BorderStyle.FixedSingle;
            pbAirlineImage.CustomizableEdges = customizableEdges9;
            pbAirlineImage.ImageRotate = 0F;
            pbAirlineImage.Location = new Point(150, 79);
            pbAirlineImage.Name = "pbAirlineImage";
            pbAirlineImage.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pbAirlineImage.Size = new Size(150, 150);
            pbAirlineImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAirlineImage.TabIndex = 6;
            pbAirlineImage.TabStop = false;
            // 
            // dgvAirlines
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAirlines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAirlines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAirlines.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAirlines.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAirlines.GridColor = Color.FromArgb(231, 229, 255);
            dgvAirlines.Location = new Point(420, 50);
            dgvAirlines.Name = "dgvAirlines";
            dgvAirlines.ReadOnly = true;
            dgvAirlines.RowHeadersVisible = false;
            dgvAirlines.RowHeadersWidth = 51;
            dgvAirlines.Size = new Size(790, 260);
            dgvAirlines.TabIndex = 7;
            dgvAirlines.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAirlines.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAirlines.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAirlines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAirlines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAirlines.ThemeStyle.BackColor = Color.White;
            dgvAirlines.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAirlines.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAirlines.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAirlines.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAirlines.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAirlines.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAirlines.ThemeStyle.HeaderStyle.Height = 29;
            dgvAirlines.ThemeStyle.ReadOnly = true;
            dgvAirlines.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAirlines.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAirlines.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAirlines.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAirlines.ThemeStyle.RowsStyle.Height = 29;
            dgvAirlines.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAirlines.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvAirlines.CellContentClick += dgvAirlines_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(150, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            label1.Text = "Airline Name:";
            // 
            // label4
            // 
            label4.Location = new Point(150, 255);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 11;
            label4.Text = "Airline Image:";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ManageAirlineBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAirlineName);
            Controls.Add(btnSubmit);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelectImage);
            Controls.Add(pbAirlineImage);
            Controls.Add(dgvAirlines);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "UC_ManageAirlineBrand";
            Size = new Size(1400, 610);
            ((System.ComponentModel.ISupportInitialize)pbAirlineImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAirlines).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
