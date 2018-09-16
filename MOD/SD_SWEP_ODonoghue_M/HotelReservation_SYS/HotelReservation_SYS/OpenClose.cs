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
    public partial class OpenClose : Form
    {
        public OpenClose()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rooms myRooms = new Rooms();
            myRooms.setRoom_No(Convert.ToInt32(cmbRoomNo.Text));
            myRooms.setStatus(cmbStatus.Text);

            if (cmbStatus.SelectedIndex == -1)
            {
                //testing to see that a Status has been selected
                MessageBox.Show("Status must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }

            if (Rooms.isRoomAvailable(cmbRoomNo.Text))
            {

                if (cmbStatus.Text.Equals("C"))
                {

                    MessageBox.Show("You have successfully closed the room");
                    cmbRoomNo.SelectedIndex = -1;
                    cmbStatus.SelectedIndex = -1;
                    grpCloseRoom.Visible = false;
                }

                if (cmbStatus.Text.Equals("A"))
                {
                    MessageBox.Show("You have successfully Opened the room");
                    cmbRoomNo.SelectedIndex = -1;
                    cmbStatus.SelectedIndex = -1;
                    grpCloseRoom.Visible = false;
                }




                myRooms.updateStatus(cmbStatus.Text);
            }

            else {
                MessageBox.Show("This room has a reservation pending cannot open/close", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoomNo.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
                grpCloseRoom.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

       

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void OpenClose_Load(object sender, EventArgs e)
        {
            //load combo with room No details.
            DataSet ds = new DataSet();
            ds = Rooms.getRooms(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                // if a rate hasnt been added suitable error message is displayed
                cmbRoomNo.Focus();
                MessageBox.Show("There are currently no rooms available for their status to be changed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomNo.TabStop = false;
            }
            else
            {

                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cmbRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
            }
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNo.SelectedIndex == -1)
                return;
           

            cmbStatus.SelectedIndex = 0;

            string rt = Rooms.getStatus(Convert.ToInt32(cmbRoomNo.Text.Substring(0, 3))).Trim();

            while (!cmbStatus.Text.Substring(0, 1).Trim().Equals(rt))
            {
                cmbStatus.SelectedIndex++;
            }

            grpCloseRoom.Visible = true;

        }
    }
}
