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
            this.cbBrandType = new System.Windows.Forms.ComboBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBrandType
            // 
            this.cbBrandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandType.FormattingEnabled = true;
            this.cbBrandType.Location = new System.Drawing.Point(12, 12);
            this.cbBrandType.Name = "cbBrandType";
            this.cbBrandType.Size = new System.Drawing.Size(200, 24);
            this.cbBrandType.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(218, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 24);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 42);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(760, 200);
            this.dgvResults.TabIndex = 2;
            // 
            // chartResults
            // 
            this.chartResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartResults.Location = new System.Drawing.Point(12, 248);
            this.chartResults.Name = "chartResults";
            this.chartResults.Size = new System.Drawing.Size(760, 300);
            this.chartResults.TabIndex = 3;
            this.chartResults.Text = "chartResults";
            // 
            // AnalyzeBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.chartResults);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.cbBrandType);
            this.Name = "AnalyzeBrandForm";
            this.Text = "Analyze Brand Performance";
            this.Load += new System.EventHandler(this.AnalyzeBrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ComboBox cbBrandType;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}