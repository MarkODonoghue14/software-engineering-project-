namespace HotelReservation_SYS
{
    partial class UpdateRoomRate
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
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblUpdateRoomRate = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.grpUpdateRoom = new System.Windows.Forms.GroupBox();
            this.grpUpdateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(784, 84);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(180, 336);
            this.btnUpdate1.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(133, 39);
            this.btnUpdate1.TabIndex = 16;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(211, 50);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescription.MaxLength = 30;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(278, 22);
            this.txtdescription.TabIndex = 15;
            this.txtdescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(211, 159);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 10;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(205, 22);
            this.txtRate.TabIndex = 14;
            this.txtRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(28, 154);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(59, 29);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate";
            this.lblRate.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(28, 46);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(128, 29);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(131, 182);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(125, 29);
            this.lblRoomType.TabIndex = 10;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblUpdateRoomRate
            // 
            this.lblUpdateRoomRate.AutoSize = true;
            this.lblUpdateRoomRate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoomRate.Location = new System.Drawing.Point(129, 79);
            this.lblUpdateRoomRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateRoomRate.Name = "lblUpdateRoomRate";
            this.lblUpdateRoomRate.Size = new System.Drawing.Size(252, 37);
            this.lblUpdateRoomRate.TabIndex = 9;
            this.lblUpdateRoomRate.Text = "Update Room Rate";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(313, 182);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(279, 24);
            this.cmbRoomType.TabIndex = 18;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpUpdateRoom
            // 
            this.grpUpdateRoom.Controls.Add(this.btnUpdate1);
            this.grpUpdateRoom.Controls.Add(this.txtdescription);
            this.grpUpdateRoom.Controls.Add(this.txtRate);
            this.grpUpdateRoom.Controls.Add(this.lblRate);
            this.grpUpdateRoom.Controls.Add(this.lblDescription);
            this.grpUpdateRoom.Location = new System.Drawing.Point(103, 257);
            this.grpUpdateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateRoom.Name = "grpUpdateRoom";
            this.grpUpdateRoom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateRoom.Size = new System.Drawing.Size(644, 418);
            this.grpUpdateRoom.TabIndex = 19;
            this.grpUpdateRoom.TabStop = false;
            this.grpUpdateRoom.Text = "UpdateRoomRate";
            this.grpUpdateRoom.Visible = false;
            // 
            // UpdateRoomRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 702);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpUpdateRoom);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblUpdateRoomRate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateRoomRate";
            this.Text = "UpdateRoomRate";
            this.Load += new System.EventHandler(this.UpdateRoomRate_Load);
            this.grpUpdateRoom.ResumeLayout(false);
            this.grpUpdateRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblUpdateRoomRate;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.GroupBox grpUpdateRoom;
    }
}