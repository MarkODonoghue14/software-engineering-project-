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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

      

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rbCheckOut.Checked)
            {
                // updateing db and resetting the ui
                Reservations checkOut = new Reservations();
                checkOut.getRes_ID();
                checkOut.setRes_ID(Convert.ToInt32(txtResID.Text));
                checkOut.checkOut();
                MessageBox.Show("A Customer has succesfully checkedOut");
                cboRes_ID.SelectedIndex = -1;
                rbCheckOut.Checked = false;
                grpCheckOut.Visible = false;
                //clearing cbo box
                cboRes_ID.Items.Clear();
                // repopulating the combobox with only relevant check outs. allows function to update while in the function
                DataSet ds = new DataSet();
                ds = Reservations.getCheckOuts(ds, DateTime.Now.ToString("yyyy-MM-dd"));

                if (ds.Tables["ss"].Rows.Count == 0)
                {

                    cboRes_ID.Focus();
                    MessageBox.Show("There are no rooms available for check-Out today", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
                MessageBox.Show("CheckOut must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbCheckOut.Focus();
                return;
        }

        private void txtResID_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            //populate the combobox on load
            DataSet ds = new DataSet();
            ds = Reservations.getCheckOuts(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {

                cboRes_ID.Focus();
                MessageBox.Show("There are no rooms available for check-Out today", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cboRes_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboRes_ID.SelectedIndex == -1)
                return;
            //retrieve reservation and display on UI
            Reservations myRes = new Reservations();
            myRes.getReservation(Convert.ToInt32(cboRes_ID.Text.Substring(0, 6)));

            //load form controls with data from myRes
            txtName.Text = myRes.getCust_Name();
            //formating date arrive text so that the secounds are cut from the date
            txtDateArr.Text = myRes.getDate_Arrive().ToString().Substring(0,10);
            //returning resid in the format 000001 etc
            txtResID.Text = myRes.getRes_ID().ToString("000000");



            //display reservation details
            grpCheckOut.Visible = true;
        }
    }
    }

