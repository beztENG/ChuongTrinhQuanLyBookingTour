﻿namespace ChuongTrinhQuanLyBookingTour.All_Users_Control
{
    partial class UC_AddFlight
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
            pictureBoxAirline = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            dgvFlights = new DataGridView();
            label2 = new Label();
            cmbAirline = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            label6 = new Label();
            cmbDeparture = new Guna.UI2.WinForms.Guna2ComboBox();
            label7 = new Label();
            cmbArrival = new Guna.UI2.WinForms.Guna2ComboBox();
            btnBookFlight = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnSearchFlights = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAirline
            // 
            pictureBoxAirline.CustomizableEdges = customizableEdges1;
            pictureBoxAirline.ImageRotate = 0F;
            pictureBoxAirline.Location = new Point(163, 104);
            pictureBoxAirline.Name = "pictureBoxAirline";
            pictureBoxAirline.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictureBoxAirline.Size = new Size(245, 124);
            pictureBoxAirline.TabIndex = 0;
            pictureBoxAirline.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold);
            label1.Location = new Point(163, 49);
            label1.Name = "label1";
            label1.Size = new Size(245, 35);
            label1.TabIndex = 1;
            label1.Text = "Đặt chuyến bay";
            // 
            // dgvFlights
            // 
            dgvFlights.BackgroundColor = Color.White;
            dgvFlights.BorderStyle = BorderStyle.Fixed3D;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Location = new Point(773, 104);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.Size = new Size(940, 665);
            dgvFlights.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 18F, FontStyle.Bold);
            label2.Location = new Point(1128, 49);
            label2.Name = "label2";
            label2.Size = new Size(255, 35);
            label2.TabIndex = 3;
            label2.Text = "Các chuyến bay ";
            // 
            // cmbAirline
            // 
            cmbAirline.BackColor = Color.Transparent;
            cmbAirline.CustomizableEdges = customizableEdges3;
            cmbAirline.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAirline.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAirline.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbAirline.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbAirline.Font = new Font("Segoe UI", 10F);
            cmbAirline.ForeColor = Color.FromArgb(68, 88, 112);
            cmbAirline.ItemHeight = 30;
            cmbAirline.Location = new Point(154, 298);
            cmbAirline.Name = "cmbAirline";
            cmbAirline.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbAirline.Size = new Size(254, 36);
            cmbAirline.TabIndex = 4;
            cmbAirline.SelectedIndexChanged += cmbAirline_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F);
            label3.Location = new Point(154, 274);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 5;
            label3.Text = "Hãng bay";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F);
            label6.Location = new Point(154, 446);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 11;
            label6.Text = "Điểm đi";
            // 
            // cmbDeparture
            // 
            cmbDeparture.BackColor = Color.Transparent;
            cmbDeparture.CustomizableEdges = customizableEdges5;
            cmbDeparture.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDeparture.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeparture.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbDeparture.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbDeparture.Font = new Font("Segoe UI", 10F);
            cmbDeparture.ForeColor = Color.FromArgb(68, 88, 112);
            cmbDeparture.ItemHeight = 30;
            cmbDeparture.Location = new Point(154, 470);
            cmbDeparture.Name = "cmbDeparture";
            cmbDeparture.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbDeparture.Size = new Size(254, 36);
            cmbDeparture.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F);
            label7.Location = new Point(154, 612);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 13;
            label7.Text = "Điểm đến";
            // 
            // cmbArrival
            // 
            cmbArrival.BackColor = Color.Transparent;
            cmbArrival.CustomizableEdges = customizableEdges7;
            cmbArrival.DrawMode = DrawMode.OwnerDrawFixed;
            cmbArrival.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArrival.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbArrival.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbArrival.Font = new Font("Segoe UI", 10F);
            cmbArrival.ForeColor = Color.FromArgb(68, 88, 112);
            cmbArrival.ItemHeight = 30;
            cmbArrival.Location = new Point(154, 636);
            cmbArrival.Name = "cmbArrival";
            cmbArrival.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbArrival.Size = new Size(254, 36);
            cmbArrival.TabIndex = 12;
            // 
            // btnBookFlight
            // 
            btnBookFlight.BorderRadius = 18;
            btnBookFlight.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnBookFlight.BorderThickness = 1;
            btnBookFlight.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnBookFlight.CheckedState.ForeColor = Color.White;
            btnBookFlight.CustomizableEdges = customizableEdges9;
            btnBookFlight.DisabledState.BorderColor = Color.DarkGray;
            btnBookFlight.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBookFlight.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBookFlight.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBookFlight.FillColor = Color.White;
            btnBookFlight.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnBookFlight.ForeColor = Color.Black;
            btnBookFlight.Location = new Point(1138, 775);
            btnBookFlight.Name = "btnBookFlight";
            btnBookFlight.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBookFlight.Size = new Size(225, 56);
            btnBookFlight.TabIndex = 14;
            btnBookFlight.Text = "Đặt chuyến bay";
            btnBookFlight.Click += btnBookFlight_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // btnSearchFlights
            // 
            btnSearchFlights.BorderRadius = 18;
            btnSearchFlights.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnSearchFlights.BorderThickness = 1;
            btnSearchFlights.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnSearchFlights.CheckedState.ForeColor = Color.White;
            btnSearchFlights.CustomizableEdges = customizableEdges11;
            btnSearchFlights.DisabledState.BorderColor = Color.DarkGray;
            btnSearchFlights.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchFlights.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchFlights.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchFlights.FillColor = Color.White;
            btnSearchFlights.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSearchFlights.ForeColor = Color.Black;
            btnSearchFlights.Location = new Point(163, 713);
            btnSearchFlights.Name = "btnSearchFlights";
            btnSearchFlights.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSearchFlights.Size = new Size(225, 56);
            btnSearchFlights.TabIndex = 15;
            btnSearchFlights.Text = "Tìm chuyến bay";
            btnSearchFlights.Click += btnSearchFlights_Click;
            // 
            // UC_AddFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearchFlights);
            Controls.Add(btnBookFlight);
            Controls.Add(label7);
            Controls.Add(cmbArrival);
            Controls.Add(label6);
            Controls.Add(cmbDeparture);
            Controls.Add(label3);
            Controls.Add(cmbAirline);
            Controls.Add(label2);
            Controls.Add(dgvFlights);
            Controls.Add(label1);
            Controls.Add(pictureBoxAirline);
            Name = "UC_AddFlight";
            Size = new Size(1882, 852);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirline).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAirline;
        private Label label1;
        private DataGridView dgvFlights;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAirline;
        private Label label3;
        private Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDeparture;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArrival;
        private Guna.UI2.WinForms.Guna2Button btnBookFlight;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnSearchFlights;
    }
}
