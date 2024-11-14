using Guna.UI2.WinForms;

namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class UC_ListUsers
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
            dgvUser = new Guna2DataGridView();
            guna2Elipse1 = new Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToResizeColumns = false;
            dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.GridColor = Color.Silver;
            dgvUser.Location = new Point(20, 57);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 24;
            dgvUser.Size = new Size(1160, 543);
            dgvUser.TabIndex = 0;
            dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUser.ThemeStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.GridColor = Color.Silver;
            dgvUser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5F);
            dgvUser.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUser.ThemeStyle.HeaderStyle.Height = 30;
            dgvUser.ThemeStyle.ReadOnly = true;
            dgvUser.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUser.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dgvUser.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvUser.ThemeStyle.RowsStyle.Height = 24;
            dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ListUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUser);
            Name = "UC_ListUsers";
            Size = new Size(1206, 635);
            Load += UC_ListUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna2DataGridView dgvUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
