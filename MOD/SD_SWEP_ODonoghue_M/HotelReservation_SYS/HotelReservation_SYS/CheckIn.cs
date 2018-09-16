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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //if the radio button is checked
            if (rbCheckIn.Checked)
            {
                //get the res id
                Reservations checkin = new Reservations();
                checkin.getRes_ID();
                checkin.setRes_ID(Convert.ToInt32(txtResId.Text));
                //invoke the checkin method
                checkin.checkIn();
                //confirmation message and reset the ui
                MessageBox.Show("A Customer has succesfully checkedIn");
                cboRes_ID.SelectedIndex = -1;
                rbCheckIn.Checked = false;
                grpCheckIn.Visible = false;

                // clear the res id box
                cboRes_ID.Items.Clear();
                // create and fill a new dataset that will allow the system to update on the fly you wont have to go in and out of the function in order for it to update
                DataSet ds = new DataSet();
                ds = Reservations.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));
                //if teres no check in display error message
                if (ds.Tables["ss"].Rows.Count == 0)
                {

                    cboRes_ID.Focus();
                    MessageBox.Show("There are no rooms available for check-In today", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboRes_ID.TabStop = false;
                }
                else
                {
                    // if tere is populate the combo box
                    for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    {
                        cboRes_ID.Items.Add(String.Format("{0:000000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][2].ToString());
                    }
                }





            }
            // validation that ensure that you actual select the check in
            else
                MessageBox.Show("CheckIn must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbCheckIn.Focus();
                return;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            // On load fill the res id combo box with the relevant check in options
            DataSet ds = new DataSet();
            ds = Reservations.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
               
                cboRes_ID.Focus();
                MessageBox.Show("There are no rooms available for check-In today", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRes_ID.TabStop= false;
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboRes_ID.Items.Add(String.Format("{0:000000}",ds.Tables[0].Rows[i][0])+ " " +  ds.Tables[0].Rows[i][2].ToString());
                }
            }
        }

        private void cboRes_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this stops stops system from crashing after updating. so that when the box clears to not execute the rest of the code
            if(cboRes_ID.SelectedIndex == -1)
                return;




            Reservations myRes = new Reservations();
            myRes.getReservation(Convert.ToInt32(cboRes_ID.Text.Substring(0, 6)));

            //load form controls with data from myRes

            txtName.Text = myRes.getCust_Name();
            //formating date arrive text so that the secounds are cut from the date
            txtDateDep.Text = myRes.getDate_Depart().ToString().Substring(0,10);
            //returning resid in the format 000001 etc
            txtResId.Text = myRes.getRes_ID().ToString("000000");
           




            //display reservation details
            grpCheckIn.Visible = true;

        }

        private void grpCheckIn_Enter(object sender, EventArgs e)
        {

        }
    }
}
