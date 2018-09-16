namespace HotelReservation_SYS
{
    partial class SalesAnalysis
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblGenerateSalesAnalysis = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpSaleReport = new System.Windows.Forms.GroupBox();
            this.chtYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSaleReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(38, 136);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 23);
            this.lblYear.TabIndex = 76;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(649, 61);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerate.Location = new System.Drawing.Point(445, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 32);
            this.btnGenerate.TabIndex = 72;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblGenerateSalesAnalysis
            // 
            this.lblGenerateSalesAnalysis.AutoSize = true;
            this.lblGenerateSalesAnalysis.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateSalesAnalysis.Location = new System.Drawing.Point(28, 57);
            this.lblGenerateSalesAnalysis.Name = "lblGenerateSalesAnalysis";
            this.lblGenerateSalesAnalysis.Size = new System.Drawing.Size(249, 29);
            this.lblGenerateSalesAnalysis.TabIndex = 71;
            this.lblGenerateSalesAnalysis.Text = "Generate Sales Analysis";
            this.lblGenerateSalesAnalysis.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(139, 140);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(92, 21);
            this.cmbYear.TabIndex = 79;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Location = new System.Drawing.Point(25, 366);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 32);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(608, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 82;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpSaleReport
            // 
            this.grpSaleReport.Controls.Add(this.chtYear);
            this.grpSaleReport.Controls.Add(this.btnRefresh);
            this.grpSaleReport.Controls.Add(this.btnPrint);
            this.grpSaleReport.Location = new System.Drawing.Point(33, 223);
            this.grpSaleReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleReport.Name = "grpSaleReport";
            this.grpSaleReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleReport.Size = new System.Drawing.Size(721, 419);
            this.grpSaleReport.TabIndex = 83;
            this.grpSaleReport.TabStop = false;
            this.grpSaleReport.Text = "salesreport";
            this.grpSaleReport.Visible = false;
            this.grpSaleReport.Enter += new System.EventHandler(this.grpSaleReport_Enter);
            // 
            // chtYear
            // 
            chartArea2.Name = "ChartArea1";
            this.chtYear.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtYear.Legends.Add(legend2);
            this.chtYear.Location = new System.Drawing.Point(2, 15);
            this.chtYear.Name = "chtYear";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtYear.Series.Add(series2);
            this.chtYear.Size = new System.Drawing.Size(594, 278);
            this.chtYear.TabIndex = 83;
            this.chtYear.Text = "chart1";
            this.chtYear.Click += new System.EventHandler(this.chtYear_Click);
            // 
            // SalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 672);
            this.Controls.Add(this.grpSaleReport);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblGenerateSalesAnalysis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesAnalysis";
            this.Text = "SalesAnalysis";
            this.Load += new System.EventHandler(this.SalesAnalysis_Load);
            this.grpSaleReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblGenerateSalesAnalysis;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpSaleReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYear;
    }
}