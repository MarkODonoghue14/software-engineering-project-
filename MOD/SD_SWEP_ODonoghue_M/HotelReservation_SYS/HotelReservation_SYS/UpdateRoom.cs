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
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            
            //testing to see that a type has been selected
            if (cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Type must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomType.Focus();
                return;
            }

            //test to see if a reservation is pending on a room being updated
            if (Rooms.isRoomAvailable(cmbRoomNo.Text))
            {


                //instantiate RoomRate Object
                Rooms myRooms = new Rooms();
                myRooms.setRoom_Type(cmbRoomType.Text);
                myRooms.setRoom_No(Convert.ToInt32(cmbRoomNo.Text));



                //INSERT RoomRate record into RoomRate table
                myRooms.updateRooms(Convert.ToInt32(cmbRoomNo.Text));


                //Display Confirmation Message
                MessageBox.Show("Room Type " + cmbRoomType.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                //resetting ui after successfully updateing room

                cmbRoomNo.SelectedIndex = -1;
                cmbRoomType.SelectedIndex = -1;
                grpUpdateRoom.Visible = false;
            }
            else
            {
                MessageBox.Show("This room has a reservation pending cannot update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomNo.SelectedIndex = -1;
                cmbRoomType.SelectedIndex = -1;
                grpUpdateRoom.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cmbRoomNo.SelectedIndex == -1)
            {
                //testing to see that a Room No has been selected
                MessageBox.Show("Room No must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomNo.Focus();
                return;
            }

            //set current RoomRate
            cmbRoomType.SelectedIndex = 0;
            string rt = Rooms.getRoomRate(Convert.ToInt32(cmbRoomNo.Text.Substring(0, 3))).Trim();

            while (!cmbRoomType.Text.Substring(0, 3).Trim().Equals(rt))
            {
                cmbRoomType.SelectedIndex++;
            }

                //Only allowing a user to update room after Room No has been selected
                
                grpUpdateRoom.Visible = true;

        }


        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            //load combo with room No details.
            DataSet ds = new DataSet();
            ds = Rooms.getRooms(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {

                cmbRoomNo.Focus();
                MessageBox.Show("There are no rooms availabe for update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomNo.TabStop = false;
            }

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cmbRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') );

            // fills room type combo box with relevant rates from the rates table
            DataSet dsrt = new DataSet();
            dsrt = RoomRate.getRoomRate(dsrt);

            for (int i = 0; i < dsrt.Tables["ss"].Rows.Count; i++)
                cmbRoomType.Items.Add(dsrt.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNo.SelectedIndex == -1)
                return;

            //set current RoomRate
            cmbRoomType.SelectedIndex = 0;
            string rt = Rooms.getRoomRate(Convert.ToInt32(cmbRoomNo.Text.Substring(0, 3))).Trim();
           

            while (!cmbRoomType.Text.Substring(0, 3).Trim().Equals(rt))
            {
                cmbRoomType.SelectedIndex++;
            }

            //Only allowing a user to update room after Room No has been selected

            grpUpdateRoom.Visible = true;

        }
    }
}
