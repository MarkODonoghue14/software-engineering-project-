namespace HotelReservation_SYS
{
    partial class MakeReservation
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
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblDatearrive = new System.Windows.Forms.Label();
            this.lblMakeReservation = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpReservaion = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblResID = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.grpReservaion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTypes
            // 
            this.cboTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(380, 165);
            this.cboTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(205, 24);
            this.cboTypes.TabIndex = 28;
            this.cboTypes.SelectedIndexChanged += new System.EventHandler(this.cboTypes_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(821, 71);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 39);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDepart.Location = new System.Drawing.Point(197, 254);
            this.lblDateDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(134, 29);
            this.lblDateDepart.TabIndex = 24;
            this.lblDateDepart.Text = "Date Depart";
            this.lblDateDepart.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(197, 165);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(125, 29);
            this.lblRoomType.TabIndex = 23;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblDatearrive
            // 
            this.lblDatearrive.AutoSize = true;
            this.lblDatearrive.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatearrive.Location = new System.Drawing.Point(197, 207);
            this.lblDatearrive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatearrive.Name = "lblDatearrive";
            this.lblDatearrive.Size = new System.Drawing.Size(127, 29);
            this.lblDatearrive.TabIndex = 21;
            this.lblDatearrive.Text = "Date Arrive";
            // 
            // lblMakeReservation
            // 
            this.lblMakeReservation.AutoSize = true;
            this.lblMakeReservation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeReservation.Location = new System.Drawing.Point(196, 66);
            this.lblMakeReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeReservation.Name = "lblMakeReservation";
            this.lblMakeReservation.Size = new System.Drawing.Size(242, 37);
            this.lblMakeReservation.TabIndex = 20;
            this.lblMakeReservation.Text = "Make Reservation";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(380, 210);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.MinDate = new System.DateTime(2018, 4, 26, 14, 27, 27, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(265, 22);
            this.dtpFrom.TabIndex = 29;
            this.dtpFrom.Value = new System.DateTime(2018, 4, 26, 14, 27, 27, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(380, 254);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.MinDate = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(265, 22);
            this.dtpTo.TabIndex = 30;
            this.dtpTo.Value = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(376, 297);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(271, 54);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search availability";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpReservaion
            // 
            this.grpReservaion.Controls.Add(this.btnRedo);
            this.grpReservaion.Controls.Add(this.btnConfirm);
            this.grpReservaion.Controls.Add(this.txtResID);
            this.grpReservaion.Controls.Add(this.txtCost);
            this.grpReservaion.Controls.Add(this.lblResID);
            this.grpReservaion.Controls.Add(this.lblcost);
            this.grpReservaion.Controls.Add(this.txtEmail);
            this.grpReservaion.Controls.Add(this.txtCustName);
            this.grpReservaion.Controls.Add(this.cmbRoomNo);
            this.grpReservaion.Controls.Add(this.lblEmail);
            this.grpReservaion.Controls.Add(this.lblCustName);
            this.grpReservaion.Controls.Add(this.lblRoomNo);
            this.grpReservaion.Location = new System.Drawing.Point(180, 426);
            this.grpReservaion.Margin = new System.Windows.Forms.Padding(4);
            this.grpReservaion.Name = "grpReservaion";
            this.grpReservaion.Padding = new System.Windows.Forms.Padding(4);
            this.grpReservaion.Size = new System.Drawing.Size(813, 334);
            this.grpReservaion.TabIndex = 42;
            this.grpReservaion.TabStop = false;
            this.grpReservaion.Text = "Enter Reservation Details";
            this.grpReservaion.Visible = false;
            this.grpReservaion.Enter += new System.EventHandler(this.grpReservaion_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(200, 230);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 39);
            this.btnConfirm.TabIndex = 52;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtResID
            // 
            this.txtResID.Enabled = false;
            this.txtResID.Location = new System.Drawing.Point(200, 198);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(96, 22);
            this.txtResID.TabIndex = 51;
            this.txtResID.TextChanged += new System.EventHandler(this.txtResID_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(200, 166);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(96, 22);
            this.txtCost.TabIndex = 50;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(17, 194);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(75, 29);
            this.lblResID.TabIndex = 49;
            this.lblResID.Text = "Res ID";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(17, 161);
            this.lblcost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(57, 29);
            this.lblcost.TabIndex = 48;
            this.lblcost.Text = "Cost";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 134);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 47;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(200, 90);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(265, 22);
            this.txtCustName.TabIndex = 46;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(200, 57);
            this.cmbRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(205, 24);
            this.cmbRoomNo.TabIndex = 45;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 129);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 29);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(17, 90);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(122, 29);
            this.lblCustName.TabIndex = 43;
            this.lblCustName.Text = "Cust Name";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(17, 52);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(107, 29);
            this.lblRoomNo.TabIndex = 42;
            this.lblRoomNo.Text = "Room No";
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(387, 230);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(133, 39);
            this.btnRedo.TabIndex = 53;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 870);
            this.Controls.Add(this.grpReservaion);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cboTypes);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblDatearrive);
            this.Controls.Add(this.lblMakeReservation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakeReservation";
            this.Text = "MakeReservation";
            this.Load += new System.EventHandler(this.MakeReservation_Load);
            this.grpReservaion.ResumeLayout(false);
            this.grpReservaion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblDatearrive;
        private System.Windows.Forms.Label lblMakeReservation;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpReservaion;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Button btnRedo;
    }
}