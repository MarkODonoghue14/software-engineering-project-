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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoomRate roomrate = new AddRoomRate();
            roomrate.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRoomRate uroomrate = new UpdateRoomRate();
                uroomrate.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRoom addroom = new AddRoom();
            addroom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateRoom updateroom = new UpdateRoom();
            updateroom.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenClose openclose = new OpenClose();
            openclose.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeReservation res = new MakeReservation();
            res.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CancelReservation cancel = new CancelReservation();
            cancel.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckOut co = new CheckOut();
            co.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckIn ci = new CheckIn();
            ci.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SalesAnalysis sreport = new SalesAnalysis();
            sreport.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RoomAnalysis rreport = new RoomAnalysis();
            rreport.Show();
            this.Hide();
        }
    }
}
