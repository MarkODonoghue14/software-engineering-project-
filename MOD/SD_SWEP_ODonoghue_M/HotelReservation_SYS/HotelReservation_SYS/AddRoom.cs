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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtRoomNo.Text == string.Empty)
            {
                //checking to make sure the relevant fields have been entered
                MessageBox.Show("Room No must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Room Type must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbType.Focus();
                return;
            }

          
           
            if (!txtRoomNo.Text.All(Char.IsDigit))
            {
                MessageBox.Show("RoomNo must be numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();
                return;

            }

            if (!Rooms.roomExists(int.Parse(txtRoomNo.Text)))
            {
                Rooms addRoom = new Rooms(int.Parse(txtRoomNo.Text), cmbType.Text, txtStatus.Text);
                addRoom.addRoom();
                MessageBox.Show("A new room has been registered");
                txtRoomNo.Clear();
                cmbType.SelectedIndex = -1;
                
            }
           
            else
            {
                //resetiing ui if a room is registered
                MessageBox.Show("This room already exist please try re-enter a valid room no");
               


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //checking to see if numeric values are being entered
            if (txtRoomNo.Text.Equals(""))
                return;
            if (txtRoomNo.Text.All(Char.IsDigit))
            {

            }
            else
            {
                MessageBox.Show("Only accepts numeric values");
                txtRoomNo.Text = "";
                txtRoomNo.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


       

        private void AddRoom_Load_1(object sender, EventArgs e)
        {
            //load combo with roomrate details.
            DataSet ds = new DataSet();
            ds = RoomRate.getRoomRate(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                // if a rate hasnt been added suitable error message is displayed

                MessageBox.Show("A rate has not been entered please add a roomrate before adding a room", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {


                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cmbType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
            }
        }





    }
}

