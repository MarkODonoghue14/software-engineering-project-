using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation_SYS
{
    public partial class CancelReservation : Form
    {
        private Label lblResID;
        private Label lblCancelReservation;
        private Button btnback;
        private GroupBox grpDeleteRes;
        private TextBox txtDateArr;
        private Label lblRes;
        private TextBox txtResId;
        private Label lblDateDep;
        private Label lblCustomer;
        private Label lblDate_Arr;
        private TextBox txtDateDep;
        private TextBox txtName;
        private Button button1;
        private ComboBox cboRes_ID;

        public CancelReservation()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblResID = new System.Windows.Forms.Label();
            this.lblCancelReservation = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.cboRes_ID = new System.Windows.Forms.ComboBox();
            this.grpDeleteRes = new System.Windows.Forms.GroupBox();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.lblDateDep = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDate_Arr = new System.Windows.Forms.Label();
            this.txtDateDep = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtDateArr = new System.Windows.Forms.TextBox();
            this.grpDeleteRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(117, 147);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(70, 29);
            this.lblResID.TabIndex = 30;
            this.lblResID.Text = "ResID";
            // 
            // lblCancelReservation
            // 
            this.lblCancelReservation.AutoSize = true;
            this.lblCancelReservation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelReservation.Location = new System.Drawing.Point(115, 51);
            this.lblCancelReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelReservation.Name = "lblCancelReservation";
            this.lblCancelReservation.Size = new System.Drawing.Size(255, 37);
            this.lblCancelReservation.TabIndex = 29;
            this.lblCancelReservation.Text = "Cancel Reservation";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(787, 49);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 39);
            this.btnback.TabIndex = 33;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboRes_ID
            // 
            this.cboRes_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRes_ID.FormattingEnabled = true;
            this.cboRes_ID.Location = new System.Drawing.Point(272, 152);
            this.cboRes_ID.Margin = new System.Windows.Forms.Padding(4);
            this.cboRes_ID.Name = "cboRes_ID";
            this.cboRes_ID.Size = new System.Drawing.Size(261, 24);
            this.cboRes_ID.TabIndex = 64;
            this.cboRes_ID.SelectedIndexChanged += new System.EventHandler(this.cboRes_ID_SelectedIndexChanged);
            // 
            // grpDeleteRes
            // 
            this.grpDeleteRes.Controls.Add(this.txtDateArr);
            this.grpDeleteRes.Controls.Add(this.lblRes);
            this.grpDeleteRes.Controls.Add(this.txtResId);
            this.grpDeleteRes.Controls.Add(this.lblDateDep);
            this.grpDeleteRes.Controls.Add(this.lblCustomer);
            this.grpDeleteRes.Controls.Add(this.lblDate_Arr);
            this.grpDeleteRes.Controls.Add(this.txtDateDep);
            this.grpDeleteRes.Controls.Add(this.txtName);
            this.grpDeleteRes.Controls.Add(this.button1);
            this.grpDeleteRes.Location = new System.Drawing.Point(67, 217);
            this.grpDeleteRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteRes.Name = "grpDeleteRes";
            this.grpDeleteRes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteRes.Size = new System.Drawing.Size(697, 399);
            this.grpDeleteRes.TabIndex = 65;
            this.grpDeleteRes.TabStop = false;
            this.grpDeleteRes.Text = "Delete Reservation";
            this.grpDeleteRes.Visible = false;
            // 
            // txtResId
            // 
            this.txtResId.Enabled = false;
            this.txtResId.Location = new System.Drawing.Point(356, 304);
            this.txtResId.Margin = new System.Windows.Forms.Padding(4);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(169, 22);
            this.txtResId.TabIndex = 68;
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDep.Location = new System.Drawing.Point(42, 228);
            this.lblDateDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(188, 29);
            this.lblDateDep.TabIndex = 67;
            this.lblDateDep.Text = "Date Of Depature";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(42, 84);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(111, 29);
            this.lblCustomer.TabIndex = 66;
            this.lblCustomer.Text = "Customer";
            // 
            // lblDate_Arr
            // 
            this.lblDate_Arr.AutoSize = true;
            this.lblDate_Arr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Arr.Location = new System.Drawing.Point(42, 155);
            this.lblDate_Arr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate_Arr.Name = "lblDate_Arr";
            this.lblDate_Arr.Size = new System.Drawing.Size(154, 29);
            this.lblDate_Arr.TabIndex = 65;
            this.lblDate_Arr.Text = "DateOFArrival";
            // 
            // txtDateDep
            // 
            this.txtDateDep.Enabled = false;
            this.txtDateDep.Location = new System.Drawing.Point(356, 235);
            this.txtDateDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateDep.Name = "txtDateDep";
            this.txtDateDep.Size = new System.Drawing.Size(169, 22);
            this.txtDateDep.TabIndex = 64;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(356, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 22);
            this.txtName.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 46;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(42, 304);
            this.lblRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(82, 29);
            this.lblRes.TabIndex = 69;
            this.lblRes.Text = "Res_ID";
            // 
            // txtDateArr
            // 
            this.txtDateArr.Enabled = false;
            this.txtDateArr.Location = new System.Drawing.Point(356, 162);
            this.txtDateArr.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateArr.Name = "txtDateArr";
            this.txtDateArr.Size = new System.Drawing.Size(169, 22);
            this.txtDateArr.TabIndex = 70;
            // 
            // CancelReservation
            // 
            this.ClientSize = new System.Drawing.Size(968, 689);
            this.Controls.Add(this.grpDeleteRes);
            this.Controls.Add(this.cboRes_ID);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblResID);
            this.Controls.Add(this.lblCancelReservation);
            this.Name = "CancelReservation";
            this.Text = "Cancel Reservation";
            this.Load += new System.EventHandler(this.CancelReservation_Load);
            this.grpDeleteRes.ResumeLayout(false);
            this.grpDeleteRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CancelReservation_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Reservations.getValidReservationsForDeletion(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {

                cboRes_ID.Focus();
                MessageBox.Show("There are no reservations available to be cancelled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRes_ID.TabStop = false;
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboRes_ID.Items.Add(String.Format("{0:000000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][2].ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }


        private void txtResID_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboRes_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // stops system from crashing when updating combo box
            if(cboRes_ID.SelectedIndex == -1)
                return;
            Reservations myRes = new Reservations();
            myRes.getReservation(Convert.ToInt32(cboRes_ID.Text.Substring(0, 6)));

            //load form controls with data from myRes

            txtName.Text = myRes.getCust_Name();
            txtDateDep.Text = myRes.getDate_Depart().ToString().Substring(0,10);
            txtDateArr.Text = myRes.getDate_Arrive().ToString().Substring(0,10);
            txtResId.Text = myRes.getRes_ID().ToString("000000");




            //display reservation details
            grpDeleteRes.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // deleting the reservation and resetting the ui
            Reservations cancel = new Reservations();
            cancel.getRes_ID();
            cancel.setRes_ID(Convert.ToInt32(txtResId.Text));
            cancel.deleteReservation();
            MessageBox.Show("A reservation has been successfully cancelled");
            cboRes_ID.SelectedIndex = -1;
            grpDeleteRes.Visible = false;

            cboRes_ID.Items.Clear();

            DataSet ds = new DataSet();
            ds = Reservations.getValidReservationsForDeletion(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {

                cboRes_ID.Focus();
                MessageBox.Show("There are no reservations available to be cancelled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRes_ID.TabStop = false;
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboRes_ID.Items.Add(String.Format("{0:000000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][2].ToString());
                }
            }

        }
    }
}
