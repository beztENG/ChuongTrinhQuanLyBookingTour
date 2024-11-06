namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    partial class UC_DisableRoom
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
            dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            btnToggleStatus = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.ColumnHeadersHeight = 4;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.GridColor = Color.FromArgb(231, 229, 255);
            dgvRooms.Location = new Point(327, 38);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(555, 447);
            dgvRooms.TabIndex = 19;
            dgvRooms.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRooms.ThemeStyle.BackColor = Color.White;
            dgvRooms.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRooms.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRooms.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRooms.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvRooms.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRooms.ThemeStyle.HeaderStyle.Height = 4;
            dgvRooms.ThemeStyle.ReadOnly = false;
            dgvRooms.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRooms.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRooms.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRooms.ThemeStyle.RowsStyle.Height = 29;
            dgvRooms.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRooms.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnToggleStatus
            // 
            btnToggleStatus.CustomizableEdges = customizableEdges1;
            btnToggleStatus.DisabledState.BorderColor = Color.DarkGray;
            btnToggleStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToggleStatus.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToggleStatus.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToggleStatus.Font = new Font("Segoe UI", 9F);
            btnToggleStatus.ForeColor = Color.White;
            btnToggleStatus.Location = new Point(508, 505);
            btnToggleStatus.Name = "btnToggleStatus";
            btnToggleStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnToggleStatus.Size = new Size(225, 56);
            btnToggleStatus.TabIndex = 20;
            btnToggleStatus.Text = "Choose to change";
            btnToggleStatus.Click += btnToggleStatus_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_DisableRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnToggleStatus);
            Controls.Add(dgvRooms);
            Name = "UC_DisableRoom";
            Size = new Size(1083, 610);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private Guna.UI2.WinForms.Guna2Button btnToggleStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
