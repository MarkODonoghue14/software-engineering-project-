namespace HotelReservation_SYS
{
    partial class RoomAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblGenerateSalesAnalysis = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpRoomsReport = new System.Windows.Forms.GroupBox();
            this.chtRoom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRoom_Type = new System.Windows.Forms.Label();
            this.cboRoom_Type = new System.Windows.Forms.ComboBox();
            this.grpRoomsReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(821, 460);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 39);
            this.btnRefresh.TabIndex = 82;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(172, 108);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 88;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(37, 103);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 29);
            this.lblYear.TabIndex = 87;
            this.lblYear.Text = "Year";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(851, 36);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 86;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerate.Location = new System.Drawing.Point(560, 149);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 39);
            this.btnGenerate.TabIndex = 85;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblGenerateSalesAnalysis
            // 
            this.lblGenerateSalesAnalysis.AutoSize = true;
            this.lblGenerateSalesAnalysis.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateSalesAnalysis.Location = new System.Drawing.Point(35, 31);
            this.lblGenerateSalesAnalysis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerateSalesAnalysis.Name = "lblGenerateSalesAnalysis";
            this.lblGenerateSalesAnalysis.Size = new System.Drawing.Size(319, 37);
            this.lblGenerateSalesAnalysis.TabIndex = 84;
            this.lblGenerateSalesAnalysis.Text = "Generate Room Analysis";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Location = new System.Drawing.Point(32, 460);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 39);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpRoomsReport
            // 
            this.grpRoomsReport.Controls.Add(this.chtRoom);
            this.grpRoomsReport.Controls.Add(this.btnRefresh);
            this.grpRoomsReport.Controls.Add(this.btnPrint);
            this.grpRoomsReport.Location = new System.Drawing.Point(31, 210);
            this.grpRoomsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoomsReport.Name = "grpRoomsReport";
            this.grpRoomsReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoomsReport.Size = new System.Drawing.Size(961, 516);
            this.grpRoomsReport.TabIndex = 89;
            this.grpRoomsReport.TabStop = false;
            this.grpRoomsReport.Text = "RoomsReport";
            this.grpRoomsReport.Visible = false;
            this.grpRoomsReport.Enter += new System.EventHandler(this.grpRoomsReport_Enter);
            // 
            // chtRoom
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRoom.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRoom.Legends.Add(legend1);
            this.chtRoom.Location = new System.Drawing.Point(11, 32);
            this.chtRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chtRoom.Name = "chtRoom";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRoom.Series.Add(series1);
            this.chtRoom.Size = new System.Drawing.Size(792, 393);
            this.chtRoom.TabIndex = 84;
            this.chtRoom.Text = "chart1";
            // 
            // lblRoom_Type
            // 
            this.lblRoom_Type.AutoSize = true;
            this.lblRoom_Type.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom_Type.Location = new System.Drawing.Point(37, 159);
            this.lblRoom_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom_Type.Name = "lblRoom_Type";
            this.lblRoom_Type.Size = new System.Drawing.Size(60, 29);
            this.lblRoom_Type.TabIndex = 90;
            this.lblRoom_Type.Text = "Type";
            // 
            // cboRoom_Type
            // 
            this.cboRoom_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom_Type.FormattingEnabled = true;
            this.cboRoom_Type.Location = new System.Drawing.Point(172, 164);
            this.cboRoom_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom_Type.Name = "cboRoom_Type";
            this.cboRoom_Type.Size = new System.Drawing.Size(121, 24);
            this.cboRoom_Type.TabIndex = 91;
            // 
            // RoomAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 734);
            this.Controls.Add(this.cboRoom_Type);
            this.Controls.Add(this.lblRoom_Type);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblGenerateSalesAnalysis);
            this.Controls.Add(this.grpRoomsReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomAnalysis";
            this.Text = "RoomAnalysis";
            this.Load += new System.EventHandler(this.RoomAnalysis_Load);
            this.grpRoomsReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblGenerateSalesAnalysis;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpRoomsReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRoom;
        private System.Windows.Forms.Label lblRoom_Type;
        private System.Windows.Forms.ComboBox cboRoom_Type;
    }
}