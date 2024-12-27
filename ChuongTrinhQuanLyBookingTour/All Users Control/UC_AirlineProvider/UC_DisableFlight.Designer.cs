namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider
{
    partial class UC_DisableFlight
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvFlights = new Guna.UI2.WinForms.Guna2DataGridView();
            btnToggleFlightStatus = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            SuspendLayout();
            // 
            // dgvFlights
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFlights.ColumnHeadersHeight = 29;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFlights.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFlights.GridColor = Color.FromArgb(231, 229, 255);
            dgvFlights.Location = new Point(196, 64);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.RowHeadersVisible = false;
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.Size = new Size(949, 560);
            dgvFlights.TabIndex = 0;
            dgvFlights.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFlights.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvFlights.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvFlights.ThemeStyle.BackColor = Color.White;
            dgvFlights.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvFlights.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvFlights.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFlights.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvFlights.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvFlights.ThemeStyle.HeaderStyle.Height = 29;
            dgvFlights.ThemeStyle.ReadOnly = false;
            dgvFlights.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvFlights.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFlights.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvFlights.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvFlights.ThemeStyle.RowsStyle.Height = 29;
            dgvFlights.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvFlights.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnToggleFlightStatus
            // 
            btnToggleFlightStatus.BorderRadius = 10;
            btnToggleFlightStatus.CustomizableEdges = customizableEdges1;
            btnToggleFlightStatus.DisabledState.BorderColor = Color.DarkGray;
            btnToggleFlightStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggleFlightStatus.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggleFlightStatus.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggleFlightStatus.FillColor = Color.DarkTurquoise;
            btnToggleFlightStatus.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggleFlightStatus.ForeColor = Color.White;
            btnToggleFlightStatus.Location = new Point(558, 656);
            btnToggleFlightStatus.Name = "btnToggleFlightStatus";
            btnToggleFlightStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnToggleFlightStatus.Size = new Size(225, 56);
            btnToggleFlightStatus.TabIndex = 1;
            btnToggleFlightStatus.Text = "Chỉnh sửa";
            btnToggleFlightStatus.Click += btnToggleFlightStatus_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 5;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(196, 26);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search by Flight ID or Destination";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(312, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // UC_DisableFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(btnToggleFlightStatus);
            Controls.Add(dgvFlights);
            Name = "UC_DisableFlight";
            Size = new Size(1310, 744);
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvFlights;
        private Guna.UI2.WinForms.Guna2Button btnToggleFlightStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
