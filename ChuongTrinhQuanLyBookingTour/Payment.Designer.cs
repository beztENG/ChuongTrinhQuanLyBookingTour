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
        private Label lblHotelID;
        private Label lblPrice;
        private Label lblTourName;
        private Label lblReturnDate;


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
            lblBookingType = new Label();
            lblHotelID = new Label();
            lblPrice = new Label();
            lblAirline = new Label();
            lblTourName = new Label();
            lblReturnDate = new Label();
            lblStartingDate = new Label();
            lblDestination = new Label();
            lblStarting = new Label();
            lblDepartureDate = new Label();
            lblCheckInDate = new Label();
            lblRoomID = new Label();
            SuspendLayout();
            // 
            // guna2LabelTitle
            // 
            guna2LabelTitle.BackColor = Color.Transparent;
            guna2LabelTitle.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2LabelTitle.Location = new Point(356, 12);
            guna2LabelTitle.Name = "guna2LabelTitle";
            guna2LabelTitle.Size = new Size(237, 43);
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
            guna2LabelMethod.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            guna2LabelMethod.Location = new Point(100, 70);
            guna2LabelMethod.Name = "guna2LabelMethod";
            guna2LabelMethod.Size = new Size(183, 29);
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
            guna2LabelAmount.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            guna2LabelAmount.Location = new Point(100, 150);
            guna2LabelAmount.Name = "guna2LabelAmount";
            guna2LabelAmount.Size = new Size(88, 29);
            guna2LabelAmount.TabIndex = 2;
            guna2LabelAmount.Text = "Amount";
            // 
            // guna2ButtonSubmit
            // 
            guna2ButtonSubmit.BorderRadius = 10;
            guna2ButtonSubmit.CustomizableEdges = customizableEdges5;
            guna2ButtonSubmit.FillColor = Color.DarkTurquoise;
            guna2ButtonSubmit.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            guna2ButtonSubmit.ForeColor = Color.White;
            guna2ButtonSubmit.Location = new Point(213, 295);
            guna2ButtonSubmit.Name = "guna2ButtonSubmit";
            guna2ButtonSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ButtonSubmit.Size = new Size(219, 45);
            guna2ButtonSubmit.TabIndex = 5;
            guna2ButtonSubmit.Text = "Submit Payment";
            guna2ButtonSubmit.Click += guna2ButtonSubmit_Click;
            // 
            // guna2ButtonCancel
            // 
            guna2ButtonCancel.BorderRadius = 10;
            guna2ButtonCancel.CustomizableEdges = customizableEdges7;
            guna2ButtonCancel.FillColor = Color.Red;
            guna2ButtonCancel.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            guna2ButtonCancel.ForeColor = Color.White;
            guna2ButtonCancel.Location = new Point(576, 295);
            guna2ButtonCancel.Name = "guna2ButtonCancel";
            guna2ButtonCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ButtonCancel.Size = new Size(130, 45);
            guna2ButtonCancel.TabIndex = 6;
            guna2ButtonCancel.Text = "Cancel";
            guna2ButtonCancel.Click += guna2ButtonCancel_Click;
            // 
            // lblBookingType
            // 
            lblBookingType.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingType.Location = new Point(560, 82);
            lblBookingType.Name = "lblBookingType";
            lblBookingType.Size = new Size(100, 23);
            lblBookingType.TabIndex = 0;
            // 
            // lblHotelID
            // 
            lblHotelID.AutoSize = true;
            lblHotelID.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblHotelID.Location = new Point(560, 112);
            lblHotelID.Name = "lblHotelID";
            lblHotelID.Size = new Size(0, 24);
            lblHotelID.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(494, 250);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 4;
            // 
            // lblAirline
            // 
            lblAirline.AutoSize = true;
            lblAirline.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblAirline.Location = new Point(560, 112);
            lblAirline.Name = "lblAirline";
            lblAirline.Size = new Size(0, 24);
            lblAirline.TabIndex = 5;
            // 
            // lblTourName
            // 
            lblTourName.AutoSize = true;
            lblTourName.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblTourName.Location = new Point(560, 112);
            lblTourName.Name = "lblTourName";
            lblTourName.Size = new Size(0, 24);
            lblTourName.TabIndex = 7;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblReturnDate.Location = new Point(560, 245);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(0, 24);
            lblReturnDate.TabIndex = 11;
            // 
            // lblStartingDate
            // 
            lblStartingDate.AutoSize = true;
            lblStartingDate.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblStartingDate.Location = new Point(560, 215);
            lblStartingDate.Name = "lblStartingDate";
            lblStartingDate.Size = new Size(0, 24);
            lblStartingDate.TabIndex = 10;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblDestination.Location = new Point(560, 185);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(0, 24);
            lblDestination.TabIndex = 9;
            // 
            // lblStarting
            // 
            lblStarting.AutoSize = true;
            lblStarting.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblStarting.Location = new Point(560, 155);
            lblStarting.Name = "lblStarting";
            lblStarting.Size = new Size(0, 24);
            lblStarting.TabIndex = 8;
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblDepartureDate.Location = new Point(560, 155);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new Size(0, 24);
            lblDepartureDate.TabIndex = 6;
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblCheckInDate.Location = new Point(560, 185);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(0, 24);
            lblCheckInDate.TabIndex = 3;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            lblRoomID.Location = new Point(560, 155);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(0, 24);
            lblRoomID.TabIndex = 2;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 400);
            Controls.Add(lblBookingType);
            Controls.Add(lblHotelID);
            Controls.Add(lblRoomID);
            Controls.Add(lblCheckInDate);
            Controls.Add(lblPrice);
            Controls.Add(lblAirline);
            Controls.Add(lblDepartureDate);
            Controls.Add(lblTourName);
            Controls.Add(lblStarting);
            Controls.Add(lblDestination);
            Controls.Add(lblStartingDate);
            Controls.Add(lblReturnDate);
            Controls.Add(guna2LabelTitle);
            Controls.Add(guna2LabelMethod);
            Controls.Add(guna2LabelAmount);
            Controls.Add(guna2ComboBoxPaymentMethod);
            Controls.Add(guna2TextBoxAmount);
            Controls.Add(guna2ButtonSubmit);
            Controls.Add(guna2ButtonCancel);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
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

        private Label lblStartingDate;
        private Label lblDestination;
        private Label lblStarting;
        private Label lblDepartureDate;
        private Label lblCheckInDate;
        private Label lblRoomID;
    }
}
