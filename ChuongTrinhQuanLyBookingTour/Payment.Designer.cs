namespace ChuongTrinhQuanLyBookingTour
{
    partial class Payment
    {
        private System.ComponentModel.IContainer components = null;

        // Declare the UI components
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxPaymentMethod;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAmount;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSubmit;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2LabelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2LabelAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2LabelMethod;
        private Label lblBookingType;
        private Label lblAirline;
        private Label lblDepartureDate;
        private Label lblHotelID;
        private Label lblRoomID;
        private Label lblCheckInDate;
        private Label lblPrice;
        private Label lblTourName;
        private Label lblStartingDate;
        private Label lblReturnDate;
        private Label lblStarting;
        private Label lblDestination;


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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2LabelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ComboBoxPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2LabelMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBoxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            guna2LabelAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            guna2ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
           

            // Khởi tạo các label mới
            this.lblBookingType = new System.Windows.Forms.Label();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAirline = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblTourName = new System.Windows.Forms.Label();
            this.lblStarting = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();

            // Thiết lập thuộc tính cho các label

            this.lblHotelID.AutoSize = true;
            this.lblRoomID.AutoSize = true;
            this.lblCheckInDate.AutoSize = true;
            this.lblPrice.AutoSize = true;
            this.lblAirline.AutoSize = true;
            this.lblDepartureDate.AutoSize = true;
            this.lblTourName.AutoSize = true;
            this.lblStarting.AutoSize = true;
            this.lblDestination.AutoSize = true;
            this.lblStartingDate.AutoSize = true;
            this.lblReturnDate.AutoSize = true;

            // Đặt vị trí cho các label
            this.lblBookingType.Location = new System.Drawing.Point(20,20);
            this.lblHotelID.Location = new System.Drawing.Point(20, 50);
            this.lblRoomID.Location = new System.Drawing.Point(20, 80);
            this.lblCheckInDate.Location = new System.Drawing.Point(20, 110);       
            this.lblAirline.Location = new System.Drawing.Point(20, 50);
            this.lblDepartureDate.Location = new System.Drawing.Point(20, 80);
            this.lblTourName.Location = new System.Drawing.Point(20, 50);
            this.lblStarting.Location = new System.Drawing.Point(20, 80);
            this.lblDestination.Location = new System.Drawing.Point(20, 110);
            this.lblStartingDate.Location = new System.Drawing.Point(20, 140);
            this.lblReturnDate.Location = new System.Drawing.Point(20, 170);
            this.lblPrice.Location = new System.Drawing.Point(20, 200);
            // Thêm các label vào form
            this.Controls.Add(this.lblBookingType);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAirline);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.lblReturnDate);
            // 
            // guna2LabelTitle
            // 
            guna2LabelTitle.BackColor = Color.Transparent;
            guna2LabelTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            guna2LabelTitle.Location = new Point(150, 12);
            guna2LabelTitle.Name = "guna2LabelTitle";
            guna2LabelTitle.Size = new Size(209, 37);
            guna2LabelTitle.TabIndex = 0;
            guna2LabelTitle.Text = "Payment Form";
            // 
            // guna2ComboBoxPaymentMethod
            // 
            guna2ComboBoxPaymentMethod.BackColor = Color.Transparent;
            guna2ComboBoxPaymentMethod.BorderRadius = 8;
            guna2ComboBoxPaymentMethod.CustomizableEdges = customizableEdges1;
            guna2ComboBoxPaymentMethod.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxPaymentMethod.FillColor = Color.WhiteSmoke;
            guna2ComboBoxPaymentMethod.FocusedColor = Color.Empty;
            guna2ComboBoxPaymentMethod.Font = new Font("Arial", 12F);
            guna2ComboBoxPaymentMethod.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBoxPaymentMethod.ItemHeight = 30;
            guna2ComboBoxPaymentMethod.Items.AddRange(new object[] { "Select Payment Method", "Credit Card", "PayPal", "Bank Transfer" });
            guna2ComboBoxPaymentMethod.Location = new Point(100, 100);
            guna2ComboBoxPaymentMethod.Name = "guna2ComboBoxPaymentMethod";
            guna2ComboBoxPaymentMethod.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBoxPaymentMethod.Size = new Size(300, 36);
            guna2ComboBoxPaymentMethod.TabIndex = 3;
            // 
            // guna2LabelMethod
            // 
            guna2LabelMethod.BackColor = Color.Transparent;
            guna2LabelMethod.Font = new Font("Arial", 12F);
            guna2LabelMethod.Location = new Point(100, 70);
            guna2LabelMethod.Name = "guna2LabelMethod";
            guna2LabelMethod.Size = new Size(152, 25);
            guna2LabelMethod.TabIndex = 1;
            guna2LabelMethod.Text = "Payment Method";
            // 
            // guna2TextBoxAmount
            // 
            guna2TextBoxAmount.BorderRadius = 8;
            guna2TextBoxAmount.CustomizableEdges = customizableEdges3;
            guna2TextBoxAmount.DefaultText = "";
            guna2TextBoxAmount.FillColor = Color.WhiteSmoke;
            guna2TextBoxAmount.Font = new Font("Arial", 12F);
            guna2TextBoxAmount.Location = new Point(100, 180);
            guna2TextBoxAmount.Margin = new Padding(3, 4, 3, 4);
            guna2TextBoxAmount.Name = "guna2TextBoxAmount";
            guna2TextBoxAmount.PasswordChar = '\0';
            guna2TextBoxAmount.PlaceholderText = "Enter Amount";
            guna2TextBoxAmount.SelectedText = "";
            guna2TextBoxAmount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBoxAmount.Size = new Size(300, 40);
            guna2TextBoxAmount.TabIndex = 4;
            // 
            // guna2LabelAmount
            // 
            guna2LabelAmount.BackColor = Color.Transparent;
            guna2LabelAmount.Font = new Font("Arial", 12F);
            guna2LabelAmount.Location = new Point(100, 150);
            guna2LabelAmount.Name = "guna2LabelAmount";
            guna2LabelAmount.Size = new Size(69, 25);
            guna2LabelAmount.TabIndex = 2;
            guna2LabelAmount.Text = "Amount";
            // 
            // guna2ButtonSubmit
            // 
            guna2ButtonSubmit.BorderRadius = 8;
            guna2ButtonSubmit.CustomizableEdges = customizableEdges5;
            guna2ButtonSubmit.FillColor = Color.SeaGreen;
            guna2ButtonSubmit.Font = new Font("Arial", 12F);
            guna2ButtonSubmit.ForeColor = Color.White;
            guna2ButtonSubmit.Location = new Point(100, 250);
            guna2ButtonSubmit.Name = "guna2ButtonSubmit";
            guna2ButtonSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ButtonSubmit.Size = new Size(130, 45);
            guna2ButtonSubmit.TabIndex = 5;
            guna2ButtonSubmit.Text = "Submit Payment";
            guna2ButtonSubmit.Click += guna2ButtonSubmit_Click;
            // 
            // guna2ButtonCancel
            // 
            guna2ButtonCancel.BorderRadius = 8;
            guna2ButtonCancel.CustomizableEdges = customizableEdges7;
            guna2ButtonCancel.FillColor = Color.Tomato;
            guna2ButtonCancel.Font = new Font("Arial", 12F);
            guna2ButtonCancel.ForeColor = Color.White;
            guna2ButtonCancel.Location = new Point(270, 250);
            guna2ButtonCancel.Name = "guna2ButtonCancel";
            guna2ButtonCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ButtonCancel.Size = new Size(130, 45);
            guna2ButtonCancel.TabIndex = 6;
            guna2ButtonCancel.Text = "Cancel";
            guna2ButtonCancel.Click += guna2ButtonCancel_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(guna2LabelTitle);
            Controls.Add(guna2LabelMethod);
            Controls.Add(guna2LabelAmount);
            Controls.Add(guna2ComboBoxPaymentMethod);
            Controls.Add(guna2TextBoxAmount);
            Controls.Add(guna2ButtonSubmit);
            Controls.Add(guna2ButtonCancel);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Event handler for the Submit button
       

        // Event handler for the Cancel button
        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form when Cancel is clicked
        }
    }
}
