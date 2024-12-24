namespace ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_Admin
{
    partial class AnalyzeBrandForm
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
            cbBrandType = new ComboBox();
            btnAnalyze = new Button();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // cbBrandType
            // 
            cbBrandType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrandType.Font = new Font("Montserrat", 9F);
            cbBrandType.FormattingEnabled = true;
            cbBrandType.Location = new Point(12, 15);
            cbBrandType.Margin = new Padding(3, 4, 3, 4);
            cbBrandType.Name = "cbBrandType";
            cbBrandType.Size = new Size(200, 29);
            cbBrandType.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalyze.Location = new Point(251, 15);
            btnAnalyze.Margin = new Padding(3, 4, 3, 4);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(92, 30);
            btnAnalyze.TabIndex = 1;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 52);
            dgvResults.Margin = new Padding(3, 4, 3, 4);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 24;
            dgvResults.Size = new Size(1113, 633);
            dgvResults.TabIndex = 2;
            // 
            // AnalyzeBrandForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvResults);
            Controls.Add(btnAnalyze);
            Controls.Add(cbBrandType);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnalyzeBrandForm";
            Size = new Size(1144, 701);
            Load += AnalyzeBrandForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ComboBox cbBrandType;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}


