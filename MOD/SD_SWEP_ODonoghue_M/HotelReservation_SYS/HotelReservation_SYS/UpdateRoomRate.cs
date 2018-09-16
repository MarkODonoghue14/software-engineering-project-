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
    public partial class UpdateRoomRate : Form
    {
        public UpdateRoomRate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cmbRoomType.SelectedIndex == -1)
            {
                return;
            }
            //find Rate details
            RoomRate updRoomRate = new RoomRate();
            updRoomRate.getRoomRate(cmbRoomType.Text.Substring(0, 3));

            if (updRoomRate.getRoom_Type().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomType.Focus();
                return;
            }

            //display Rate details
            txtdescription.Text = updRoomRate.getDescription();
            txtRate.Text = updRoomRate.getRate().ToString();

            //display details
            grpUpdateRoom.Visible = true;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //checking to see if string values are being entered
            if (txtdescription.Text.Equals(""))
                return;
            if (txtdescription.Text.Any(Char.IsDigit) || txtdescription.Text.Any(Char.IsSymbol) || txtdescription.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("This textbox only accepts letters");
                txtdescription.Text = "";
                txtdescription.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //checking to see if numeric values are being entered
            
            Decimal number;
            if (txtRate.Text.Equals(""))
                return;
            //allows user to enter a decimal value. So the . in the decimal dosent cause a validation error
            if (!Decimal.TryParse(txtRate.Text, out number))
            {
                MessageBox.Show("This textbox only accepts numeric values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Text = "";
                txtRate.Focus();
            }

        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text == string.Empty)
            {
                //Checking if description has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescription.Focus();
                return;
            }

            if (txtRate.Text == String.Empty)
            {
                //Checking if Rate has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Rate must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

            if (txtdescription.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Description can only contain letters");
                txtdescription.Focus();
                return;
            }

            Decimal number;

            if (!Decimal.TryParse(txtRate.Text, out number))
            {
                //Checks to make sure that rate has been entered in decimal format
                MessageBox.Show("Rate must be a decimal number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                return;
            }



            else
            {
               


                //validate data


                //instantiate RoomRate Object
                RoomRate myRoomRate = new RoomRate();
                myRoomRate.setDescription(txtdescription.Text);
                myRoomRate.setRate(Convert.ToDecimal(txtRate.Text));


                //INSERT RoomRate record into RoomRate table
                myRoomRate.updateRoomRate(cmbRoomType.Text.Substring(0,3));


                //Display Confirmation Message
                MessageBox.Show("Room Type " + cmbRoomType.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                //resetting ui after successfully updateing room
                txtdescription.Clear();
                txtRate.Clear();
                cmbRoomType.SelectedIndex = -1;
                grpUpdateRoom.Visible = false;
                //clearinf the combo box so results arent  duplicated
                cmbRoomType.Items.Clear();

                //resetting the combo box with the updated details
                DataSet ds = new DataSet();
                ds = RoomRate.getRoomRate(ds);

                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cmbRoomType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRoomRate_Load(object sender, EventArgs e)
        {
            //load combo with roomrate details.
            DataSet ds = new DataSet();
            ds = RoomRate.getRoomRate(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                // if a rate hasnt been added suitable error message is displayed
                cmbRoomType.Focus();
                MessageBox.Show("There are no room rates available for update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomType.TabStop = false;
                
            }



            else
            {
                //populate combo box
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cmbRoomType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());

            }
        }




    }
}
