namespace HotelReservation_SYS
{
    partial class CheckIn
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
            this.lblResID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.rbCheckIn = new System.Windows.Forms.RadioButton();
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDate_Depart = new System.Windows.Forms.Label();
            this.txtDateDep = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboRes_ID = new System.Windows.Forms.ComboBox();
            this.grpCheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(132, 145);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(60, 23);
            this.lblResID.TabIndex = 59;
            this.lblResID.Text = "Res ID";
            this.lblResID.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-39, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cost";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(31, 25);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(72, 23);
            this.lblCheckIn.TabIndex = 52;
            this.lblCheckIn.Text = "CheckIn";
            this.lblCheckIn.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(541, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(198, 238);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 32);
            this.btnConfirm.TabIndex = 46;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(131, 56);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(97, 29);
            this.lblCheck.TabIndex = 42;
            this.lblCheck.Text = "Check In";
            this.lblCheck.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbCheckIn
            // 
            this.rbCheckIn.AutoSize = true;
            this.rbCheckIn.Location = new System.Drawing.Point(267, 33);
            this.rbCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCheckIn.Name = "rbCheckIn";
            this.rbCheckIn.Size = new System.Drawing.Size(14, 13);
            this.rbCheckIn.TabIndex = 62;
            this.rbCheckIn.TabStop = true;
            this.rbCheckIn.UseVisualStyleBackColor = true;
            this.rbCheckIn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Controls.Add(this.txtResId);
            this.grpCheckIn.Controls.Add(this.label1);
            this.grpCheckIn.Controls.Add(this.lblCustomer);
            this.grpCheckIn.Controls.Add(this.lblDate_Depart);
            this.grpCheckIn.Controls.Add(this.txtDateDep);
            this.grpCheckIn.Controls.Add(this.txtName);
            this.grpCheckIn.Controls.Add(this.rbCheckIn);
            this.grpCheckIn.Controls.Add(this.lblCheckIn);
            this.grpCheckIn.Controls.Add(this.btnConfirm);
            this.grpCheckIn.Location = new System.Drawing.Point(101, 236);
            this.grpCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheckIn.Size = new System.Drawing.Size(523, 324);
            this.grpCheckIn.TabIndex = 63;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "CheckIn";
            this.grpCheckIn.Visible = false;
            this.grpCheckIn.Enter += new System.EventHandler(this.grpCheckIn_Enter);
            // 
            // txtResId
            // 
            this.txtResId.Enabled = false;
            this.txtResId.Location = new System.Drawing.Point(267, 199);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(128, 20);
            this.txtResId.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Res_Id";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(31, 94);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(87, 23);
            this.lblCustomer.TabIndex = 66;
            this.lblCustomer.Text = "Customer";
            // 
            // lblDate_Depart
            // 
            this.lblDate_Depart.AutoSize = true;
            this.lblDate_Depart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Depart.Location = new System.Drawing.Point(31, 145);
            this.lblDate_Depart.Name = "lblDate_Depart";
            this.lblDate_Depart.Size = new System.Drawing.Size(147, 23);
            this.lblDate_Depart.TabIndex = 65;
            this.lblDate_Depart.Text = "Date of Depature";
            // 
            // txtDateDep
            // 
            this.txtDateDep.Enabled = false;
            this.txtDateDep.Location = new System.Drawing.Point(267, 145);
            this.txtDateDep.Name = "txtDateDep";
            this.txtDateDep.Size = new System.Drawing.Size(128, 20);
            this.txtDateDep.TabIndex = 64;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(267, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 63;
            // 
            // cboRes_ID
            // 
            this.cboRes_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRes_ID.FormattingEnabled = true;
            this.cboRes_ID.Location = new System.Drawing.Point(219, 147);
            this.cboRes_ID.Name = "cboRes_ID";
            this.cboRes_ID.Size = new System.Drawing.Size(197, 21);
            this.cboRes_ID.TabIndex = 63;
            this.cboRes_ID.SelectedIndexChanged += new System.EventHandler(this.cboRes_ID_SelectedIndexChanged);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 606);
            this.Controls.Add(this.cboRes_ID);
            this.Controls.Add(this.grpCheckIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCheck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.grpCheckIn.ResumeLayout(false);
            this.grpCheckIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.RadioButton rbCheckIn;
        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.ComboBox cboRes_ID;
        private System.Windows.Forms.TextBox txtDateDep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDate_Depart;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label label1;
    }
}