namespace HotelReservation_SYS
{
    partial class UpdateRoom
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblUpdateRoom = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.grpUpdateRoom = new System.Windows.Forms.GroupBox();
            this.grpUpdateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(503, 54);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 170);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 39);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(28, 48);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(125, 29);
            this.lblRoomType.TabIndex = 21;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(87, 158);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(107, 29);
            this.lblRoomNo.TabIndex = 19;
            this.lblRoomNo.Text = "Room No";
            // 
            // lblUpdateRoom
            // 
            this.lblUpdateRoom.AutoSize = true;
            this.lblUpdateRoom.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoom.Location = new System.Drawing.Point(85, 57);
            this.lblUpdateRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateRoom.Name = "lblUpdateRoom";
            this.lblUpdateRoom.Size = new System.Drawing.Size(195, 37);
            this.lblUpdateRoom.TabIndex = 18;
            this.lblUpdateRoom.Text = "Update Room ";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(184, 55);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(205, 24);
            this.cmbRoomType.TabIndex = 27;
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(243, 164);
            this.cmbRoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(205, 24);
            this.cmbRoomNo.TabIndex = 28;
            this.cmbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNo_SelectedIndexChanged);
            // 
            // grpUpdateRoom
            // 
            this.grpUpdateRoom.Controls.Add(this.cmbRoomType);
            this.grpUpdateRoom.Controls.Add(this.btnUpdate);
            this.grpUpdateRoom.Controls.Add(this.lblRoomType);
            this.grpUpdateRoom.Location = new System.Drawing.Point(59, 309);
            this.grpUpdateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateRoom.Name = "grpUpdateRoom";
            this.grpUpdateRoom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateRoom.Size = new System.Drawing.Size(540, 284);
            this.grpUpdateRoom.TabIndex = 30;
            this.grpUpdateRoom.TabStop = false;
            this.grpUpdateRoom.Text = "UpdateRoom";
            this.grpUpdateRoom.Visible = false;
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 666);
            this.Controls.Add(this.grpUpdateRoom);
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblUpdateRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateRoom";
            this.Text = "UpdateRoom";
            this.Load += new System.EventHandler(this.UpdateRoom_Load);
            this.grpUpdateRoom.ResumeLayout(false);
            this.grpUpdateRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblUpdateRoom;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.GroupBox grpUpdateRoom;
    }
}