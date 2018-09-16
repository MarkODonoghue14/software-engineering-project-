namespace HotelReservation_SYS
{
    partial class CheckOut
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
            this.rbCheckOut = new System.Windows.Forms.RadioButton();
            this.lblResID = new System.Windows.Forms.Label();
            this.LblCheck = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.txtDateArr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblDateArr = new System.Windows.Forms.Label();
            this.cboRes_ID = new System.Windows.Forms.ComboBox();
            this.grpCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCheckOut
            // 
            this.rbCheckOut.AutoSize = true;
            this.rbCheckOut.Location = new System.Drawing.Point(404, 76);
            this.rbCheckOut.Name = "rbCheckOut";
            this.rbCheckOut.Size = new System.Drawing.Size(17, 16);
            this.rbCheckOut.TabIndex = 70;
            this.rbCheckOut.TabStop = true;
            this.rbCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(206, 171);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(75, 29);
            this.lblResID.TabIndex = 68;
            this.lblResID.Text = "Res ID";
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheck.Location = new System.Drawing.Point(79, 66);
            this.LblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(110, 29);
            this.LblCheck.TabIndex = 67;
            this.LblCheck.Text = "CheckOut";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(730, 79);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(302, 328);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 39);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(204, 74);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(144, 37);
            this.lblCheckOut.TabIndex = 63;
            this.lblCheckOut.Text = "Check Out";
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Controls.Add(this.txtResID);
            this.grpCheckOut.Controls.Add(this.lblres);
            this.grpCheckOut.Controls.Add(this.txtDateArr);
            this.grpCheckOut.Controls.Add(this.txtName);
            this.grpCheckOut.Controls.Add(this.lblCustName);
            this.grpCheckOut.Controls.Add(this.lblDateArr);
            this.grpCheckOut.Controls.Add(this.rbCheckOut);
            this.grpCheckOut.Controls.Add(this.LblCheck);
            this.grpCheckOut.Controls.Add(this.btnConfirm);
            this.grpCheckOut.Location = new System.Drawing.Point(127, 263);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(768, 403);
            this.grpCheckOut.TabIndex = 71;
            this.grpCheckOut.TabStop = false;
            this.grpCheckOut.Text = "CheckOut";
            this.grpCheckOut.Visible = false;
            // 
            // txtResID
            // 
            this.txtResID.Enabled = false;
            this.txtResID.Location = new System.Drawing.Point(404, 283);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(169, 22);
            this.txtResID.TabIndex = 76;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(79, 276);
            this.lblres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(70, 29);
            this.lblres.TabIndex = 75;
            this.lblres.Text = "ResID";
            // 
            // txtDateArr
            // 
            this.txtDateArr.Enabled = false;
            this.txtDateArr.Location = new System.Drawing.Point(404, 216);
            this.txtDateArr.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateArr.Name = "txtDateArr";
            this.txtDateArr.Size = new System.Drawing.Size(169, 22);
            this.txtDateArr.TabIndex = 74;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(404, 150);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 22);
            this.txtName.TabIndex = 73;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(79, 143);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(117, 29);
            this.lblCustName.TabIndex = 72;
            this.lblCustName.Text = "CustName";
            // 
            // lblDateArr
            // 
            this.lblDateArr.AutoSize = true;
            this.lblDateArr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateArr.Location = new System.Drawing.Point(79, 209);
            this.lblDateArr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateArr.Name = "lblDateArr";
            this.lblDateArr.Size = new System.Drawing.Size(159, 29);
            this.lblDateArr.TabIndex = 71;
            this.lblDateArr.Text = "Date of Arrival";
            // 
            // cboRes_ID
            // 
            this.cboRes_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRes_ID.FormattingEnabled = true;
            this.cboRes_ID.Location = new System.Drawing.Point(346, 176);
            this.cboRes_ID.Margin = new System.Windows.Forms.Padding(4);
            this.cboRes_ID.Name = "cboRes_ID";
            this.cboRes_ID.Size = new System.Drawing.Size(261, 24);
            this.cboRes_ID.TabIndex = 72;
            this.cboRes_ID.SelectedIndexChanged += new System.EventHandler(this.cboRes_ID_SelectedIndexChanged);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 704);
            this.Controls.Add(this.cboRes_ID);
            this.Controls.Add(this.grpCheckOut);
            this.Controls.Add(this.lblResID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCheckOut);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.grpCheckOut.ResumeLayout(false);
            this.grpCheckOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCheckOut;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblDateArr;
        private System.Windows.Forms.ComboBox cboRes_ID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDateArr;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Label lblres;
    }
}