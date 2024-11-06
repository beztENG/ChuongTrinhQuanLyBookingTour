namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_TourProvider
{
    partial class UC_DisableTour
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewTours = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTours).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTours
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewTours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewTours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTours.ColumnHeadersHeight = 4;
            dataGridViewTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewTours.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTours.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewTours.Location = new Point(286, 49);
            dataGridViewTours.Name = "dataGridViewTours";
            dataGridViewTours.RowHeadersVisible = false;
            dataGridViewTours.RowHeadersWidth = 51;
            dataGridViewTours.Size = new Size(853, 810);
            dataGridViewTours.TabIndex = 0;
            dataGridViewTours.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewTours.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewTours.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewTours.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewTours.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewTours.ThemeStyle.BackColor = Color.White;
            dataGridViewTours.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewTours.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewTours.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTours.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewTours.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewTours.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewTours.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewTours.ThemeStyle.ReadOnly = false;
            dataGridViewTours.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewTours.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTours.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewTours.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewTours.ThemeStyle.RowsStyle.Height = 29;
            dataGridViewTours.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewTours.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewTours.CellContentClick += dataGridViewTours_CellContentClick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_DisableTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewTours);
            Name = "UC_DisableTour";
            Size = new Size(1450, 1014);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewTours;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
