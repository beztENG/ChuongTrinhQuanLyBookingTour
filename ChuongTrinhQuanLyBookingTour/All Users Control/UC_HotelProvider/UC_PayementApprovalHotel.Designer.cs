namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider
{
    partial class UC_PayementApprovalHotel
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2Button btnApprove;
        private Guna.UI2.WinForms.Guna2Button btnReject;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderDetails;
        private System.Windows.Forms.Label lblOrderDetails;

        /// <summary>
        /// Clean up resources being used.
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
        /// Required method for Designer support
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            btnApprove = new Guna.UI2.WinForms.Guna2Button();
            btnReject = new Guna.UI2.WinForms.Guna2Button();
            txtOrderDetails = new Guna.UI2.WinForms.Guna2TextBox();
            lblOrderDetails = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.GridColor = Color.DarkTurquoise;
            dgvOrders.Location = new Point(20, 20);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(800, 287);
            dgvOrders.TabIndex = 0;
            dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrders.ThemeStyle.BackColor = Color.White;
            dgvOrders.ThemeStyle.GridColor = Color.DarkTurquoise;
            dgvOrders.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrders.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvOrders.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.ThemeStyle.HeaderStyle.Height = 29;
            dgvOrders.ThemeStyle.ReadOnly = true;
            dgvOrders.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrders.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvOrders.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrders.ThemeStyle.RowsStyle.Height = 29;
            dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnApprove
            // 
            btnApprove.BorderRadius = 10;
            btnApprove.CustomizableEdges = customizableEdges1;
            btnApprove.FillColor = Color.DarkTurquoise;
            btnApprove.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(20, 440);
            btnApprove.Name = "btnApprove";
            btnApprove.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnApprove.Size = new Size(120, 45);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve";
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BorderRadius = 10;
            btnReject.CustomizableEdges = customizableEdges3;
            btnReject.FillColor = Color.Red;
            btnReject.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(160, 440);
            btnReject.Name = "btnReject";
            btnReject.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReject.Size = new Size(120, 45);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject";
            btnReject.Click += btnReject_Click;
            // 
            // txtOrderDetails
            // 
            txtOrderDetails.CustomizableEdges = customizableEdges5;
            txtOrderDetails.DefaultText = "";
            txtOrderDetails.Font = new Font("Segoe UI", 9F);
            txtOrderDetails.Location = new Point(20, 340);
            txtOrderDetails.Margin = new Padding(3, 4, 3, 4);
            txtOrderDetails.Multiline = true;
            txtOrderDetails.Name = "txtOrderDetails";
            txtOrderDetails.PasswordChar = '\0';
            txtOrderDetails.PlaceholderText = "Order Details";
            txtOrderDetails.ReadOnly = true;
            txtOrderDetails.SelectedText = "";
            txtOrderDetails.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtOrderDetails.Size = new Size(800, 80);
            txtOrderDetails.TabIndex = 2;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDetails.Location = new Point(20, 310);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(149, 25);
            lblOrderDetails.TabIndex = 3;
            lblOrderDetails.Text = "Order Details";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_PayementApprovalHotel
            // 
            Controls.Add(dgvOrders);
            Controls.Add(btnApprove);
            Controls.Add(btnReject);
            Controls.Add(txtOrderDetails);
            Controls.Add(lblOrderDetails);
            Name = "UC_PayementApprovalHotel";
            Size = new Size(850, 500);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
