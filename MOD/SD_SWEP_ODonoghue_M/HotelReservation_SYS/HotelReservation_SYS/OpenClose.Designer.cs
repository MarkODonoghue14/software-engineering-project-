namespace HotelReservation_SYS
{
    partial class OpenClose
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblCloseOpen = new System.Windows.Forms.Label();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.grpCloseRoom = new System.Windows.Forms.GroupBox();
            this.grpCloseRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "A",
            "C"});
            this.cmbStatus.Location = new System.Drawing.Point(222, 62);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(205, 24);
            this.cmbStatus.TabIndex = 28;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(510, 58);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 159);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 39);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close/Open";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(70, 57);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(75, 29);
            this.LblStatus.TabIndex = 23;
            this.LblStatus.Text = "Status";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(121, 156);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(107, 29);
            this.lblRoomNo.TabIndex = 21;
            this.lblRoomNo.Text = "Room No";
            // 
            // lblCloseOpen
            // 
            this.lblCloseOpen.AutoSize = true;
            this.lblCloseOpen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseOpen.Location = new System.Drawing.Point(120, 53);
            this.lblCloseOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCloseOpen.Name = "lblCloseOpen";
            this.lblCloseOpen.Size = new System.Drawing.Size(242, 37);
            this.lblCloseOpen.TabIndex = 20;
            this.lblCloseOpen.Text = "Close/Open Room";
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(273, 156);
            this.cmbRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(205, 24);
            this.cmbRoomNo.TabIndex = 29;
            this.cmbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNo_SelectedIndexChanged);
            // 
            // grpCloseRoom
            // 
            this.grpCloseRoom.Controls.Add(this.cmbStatus);
            this.grpCloseRoom.Controls.Add(this.btnClose);
            this.grpCloseRoom.Controls.Add(this.LblStatus);
            this.grpCloseRoom.Location = new System.Drawing.Point(51, 304);
            this.grpCloseRoom.Name = "grpCloseRoom";
            this.grpCloseRoom.Size = new System.Drawing.Size(591, 315);
            this.grpCloseRoom.TabIndex = 30;
            this.grpCloseRoom.TabStop = false;
            this.grpCloseRoom.Text = "Close/Open";
            this.grpCloseRoom.Visible = false;
            // 
            // OpenClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 660);
            this.Controls.Add(this.grpCloseRoom);
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblCloseOpen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OpenClose";
            this.Text = "OpenClose";
            this.Load += new System.EventHandler(this.OpenClose_Load);
            this.grpCloseRoom.ResumeLayout(false);
            this.grpCloseRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblCloseOpen;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.GroupBox grpCloseRoom;
        private System.Windows.Forms.Button btnSearch;
    }
}