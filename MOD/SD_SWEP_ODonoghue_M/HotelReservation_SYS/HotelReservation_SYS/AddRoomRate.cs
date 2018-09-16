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
    public partial class AddRoomRate : Form
    {
        public AddRoomRate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //checking to see if letters are being entered
            if (txtRoomType.Text.Equals(""))
                return;
            if (txtRoomType.Text.Any(Char.IsDigit) || txtRoomType.Text.Any(Char.IsSymbol) || txtRoomType.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("This textbox only accepts letters");
                txtRoomType.Text = "";
                txtRoomType.Focus();
            }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            {//checking to see that letters are being entered 
                if (txtDescription.Text.Equals(""))
                    return;
            }

            //Orginal way i validated but it allowed symbols
            //if (txtDescription.Text.Any(Char.IsDigit))
            //{
            //    MessageBox.Show("This textbox only accepts letters");
            //    txtDescription.Text = "";
            //    txtDescription.Focus();
            //    return;
            //}

           


            //This validation stops didgets and symbols
            if (txtDescription.Text.Any(Char.IsDigit) || txtDescription.Text.Any(Char.IsSymbol) || txtDescription.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("This textbox only accepts letters");
                txtDescription.Text = "";
                txtDescription.Focus();
            }
            
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //checking to see if numeric values are being entered
            Decimal number;
            if (txtRate.Text.Equals(""))
                return;
            if (!Decimal.TryParse(txtRate.Text, out number))
            {
                MessageBox.Show("This textbox only accepts numeric values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Text = "";
                txtRate.Focus();               
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //closeing menu when back button is clicked
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if (txtRoomType.Text == string.Empty)
            {
                //Checking if RoomType has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Room Type must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomType.Focus();
                return;
            }

            if (txtRate.Text == String.Empty)
            {

                //Checking if Rate has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Rate must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

            if (txtDescription.Text == String.Empty)
            {
                //Checking if description has been entered correctly and putting cursor there if it isnt
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            Decimal number;

            if  (!Decimal.TryParse(txtRate.Text, out number))
                {
                  //Checks to make sure that rate has been entered in decimal format
                  MessageBox.Show("rate must be a decimal number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  txtRate.Focus();
                  return;
                }


            if (txtDescription.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Description can only contain characters");
                txtDescription.Focus();
                return;
            }

            if (txtRoomType.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("RoomType only accepts letters");
                txtRoomType.Focus();
                return;
            }

          

            if (!RoomRate.rateExists(txtRoomType.Text))
            {
                RoomRate roomRate = new RoomRate(txtRoomType.Text, txtDescription.Text, Decimal.Parse(txtRate.Text));
                roomRate.addRoomRate();
                MessageBox.Show("A new room rate has been registered");
                //Resetting ui if details have been entered correctly
                txtRoomType.Clear();
                txtDescription.Clear();
                txtRate.Clear();

            }
            else
            {
                MessageBox.Show("This rate already exist please try re-enter a valid rate");
            }
        




          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomRate_Load(object sender, EventArgs e)
        {

        }
    }
}
