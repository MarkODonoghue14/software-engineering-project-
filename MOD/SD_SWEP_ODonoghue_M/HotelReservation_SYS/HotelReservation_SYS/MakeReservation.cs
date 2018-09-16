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
    public partial class MakeReservation : Form
    {
        public MakeReservation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

            dtpFrom.MinDate = DateTime.Now;
            //This is incase someone trys to change the dates after searching for reservation
            if (cboTypes.SelectedIndex == 0)
            {
                grpReservaion.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           

            if (cboTypes.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("A Room Type must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTypes.Focus();
                return;
            }

            if (dtpFrom.Text == dtpTo.Text)// makes sure the users arrival and depature date are not the same
            {
                MessageBox.Show("You cannot make a resrvation for the same day", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpTo.MinDate < dtpFrom.Value)//makes sure that the depature date isnt before date of arrival
            {
                MessageBox.Show("You cannot make a resrvation for a date before the date of arrival", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTo.Focus();
                return;
            }

            else
            {

                //if it passes the validation create a dataset. call the method get available rooms. This method checks to confirm a booking has not been made on that date for that room
                DataSet ds = new DataSet();
               
                    
                ds = Reservations.getAvailableRooms(ds, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"), cboTypes.Text.Substring(0, 3));
                // if no rooms pass that validation displays approiate error message otherwise fills the room no box with the available rooms
                if (ds.Tables["ss"].Rows.Count == 0)
                {
                    MessageBox.Show("Sorry there are no available rooms for the period selected. Please select another Date/Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTypes.SelectedIndex = -1;
                    cboTypes.Focus();
                }
                else
                {
                    cmbRoomNo.Items.Clear();
                    for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    {
                        cmbRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                    }

                    Reservations makeRes = new Reservations();

                    //res id to string
                    txtResID.Text = Reservations.nextResId().ToString("000000");
                    //calculating the cost of the reservation giving the user a price be4 confirming reservation
                    // finding days between storing in p
                    double p = (Convert.ToDateTime(dtpTo.Text) - Convert.ToDateTime(dtpFrom.Text)).TotalDays;
                    // finding the rate
                    decimal x = Reservations.findRateprov(cboTypes.Text);
                    // making x a double so that it can be multiplied by totaldays between
                    double dbl = Convert.ToDouble(x);



                    double ans = Convert.ToDouble(p * dbl);
                    txtCost.Text = Convert.ToString(ans);
                    
                    
                  
                   grpReservaion.Visible = true;
                }
            }
        }

        private void grpReservaion_Enter(object sender, EventArgs e)
        {

        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            //checking to see that letters are being entered 
            if (txtCustName.Text.Equals(""))
                return;
            if (txtCustName.Text.Any(Char.IsDigit) || txtCustName.Text.Any(Char.IsSymbol) || txtCustName.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("This textbox only accepts letters");
                txtCustName.Text = "";
                txtCustName.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == String.Empty)
            {
                //Checking if customersname has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Customers Name must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustName.Focus();
                return;
            }

            if (txtEmail.Text == String.Empty)
            {
                //Checking if E-mail has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("E-mail must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtCustName.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("CustName only accepts letters");
                txtCustName.Focus();
                return;
            }
            //Checking if RoomNo has been selected correctly and putting cursor there if it isnt
            if (cmbRoomNo.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("A Room No must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomNo.Focus();
                return;
            }

           
            else
            {
                //adding details to reservation and calculating total cost of stay

                Reservations makeRes = new Reservations();
                makeRes.setRes_ID(Reservations.nextResId());
                makeRes.setRoom_No(Convert.ToInt32(cmbRoomNo.Text));
                makeRes.setCust_Name(txtCustName.Text.ToUpper());
                makeRes.setE_Mail(txtEmail.Text.ToUpper());
                makeRes.setDate_Arrive(dtpFrom.Value.ToString("yyyy-MM-dd"));
                makeRes.setDate_Depart(dtpTo.Value.ToString("yyyy-MM-dd"));
                makeRes.setTotal_Cost((Convert.ToDateTime(dtpTo.Text) - Convert.ToDateTime(dtpFrom.Text)).TotalDays * Reservations.findRate(makeRes.getRoom_No(Convert.ToInt32(cmbRoomNo.Text))));
                makeRes.setCheck_In("A");
                makeRes.setCheck_Out("A");
                makeRes.setRes_Status("A");
                makeRes.makeReservation();


                //Clearing the ui
                MessageBox.Show("A Reservation has been successfully made");
                txtCustName.Clear();
                txtEmail.Clear();
                cmbRoomNo.SelectedIndex = -1;
                cboTypes.SelectedIndex = -1;
                grpReservaion.Visible = false;
                

            }
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            //not allowing user to select a date in the past
            dtpTo.MinDate = dtpFrom.Value;
            if (cboTypes.SelectedIndex == 0)
            {
                grpReservaion.Hide();
            }
        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            //sets min date to today on load for both dtps
            dtpFrom.MinDate = DateTime.Now;
            dtpTo.MinDate = DateTime.Now;
            DataSet ds = new DataSet();
            ds = RoomRate.getRoomRate(ds);
            // tests to make sure tere is a room available for rent
            if (ds.Tables["ss"].Rows.Count == 0)
            {

                cmbRoomNo.Focus();
                MessageBox.Show("There are no rooms available for reservation", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomNo.TabStop = false;
            }
            else
            {
                //load combo with roomrate details.
                // this will allow a user to select a rate from the the pre-existing rates found in database
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cboTypes.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtCustName.Clear();
            txtEmail.Clear();
            cmbRoomNo.SelectedIndex = -1;
            grpReservaion.Visible = false;
        }
    }
}
