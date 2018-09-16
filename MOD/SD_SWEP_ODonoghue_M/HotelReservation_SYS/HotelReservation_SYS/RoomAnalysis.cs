using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelReservation_SYS
{
    public partial class RoomAnalysis : Form
    {
        public RoomAnalysis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully printed the document");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == -1)
            {
                //Checking if Year has been selected correctly and putting cursor there if it isnt
                MessageBox.Show("Year must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;

            }

            if (cboRoom_Type.SelectedIndex == -1)
            {
                //Checking if Year has been selected correctly and putting cursor there if it isnt
                MessageBox.Show("Type must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;

            }
            else
            {
                grpRoomsReport.Visible = true;
                chtRoom.Show();
                defineChart(cmbYear.Text.Substring(2, 2));

                //Define the chart series
                defineSeries();

                //fill Chart
                fillChart(cmbYear.Text.Substring(2, 2), cboRoom_Type.Text.Substring(0, 3));
            }
        }

        private void grpRoomsReport_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshing sales Report");
            cmbYear.SelectedIndex = -1;
            cboRoom_Type.SelectedIndex = -1;
            grpRoomsReport.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void RoomAnalysis_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Reservations.getYear(ds);


            for (int i = 0; i < ds.Tables["Year"].Rows.Count; i++)
            {
                var val = ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0');

                if (!cmbYear.Items.Contains(val))
                {
                    cmbYear.Items.Add(val);
                }
            }

            DataSet dst = new DataSet();
            cboRoom_Type.Items.Clear();
            ds = RoomRate.getRoomRate(dst);

            for (int i = 0; i < dst.Tables["ss"].Rows.Count; i++)
            {
                cboRoom_Type.Items.Add(dst.Tables[0].Rows[i][0].ToString());
            }

        }

        private void fillChart(string year, string type)
        {

            //fill chart
            chtRoom.Series["Bookings"].Points.Clear();



            //get data from database
            DataSet ds = new DataSet();
            ds = Reservations.getRoomType(ds, year, type);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))
                    chtRoom.Series["Bookings"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtRoom.Series["Bookings"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }
        }




        public String getMonthName(int MonthNo)
        {
          string monthName = "";
            switch (MonthNo)
    {
              case 1:
              monthName = "JAN";
              break;
              case 2:
              monthName = "FEB";
              break;
              case 3:
              monthName = "MAR";
              break;
              case 4:
              monthName = "APR";
              break;
              case 5:
              monthName = "MAY";
              break;
              case 6:
              monthName = "JUN";
              break;
              case 7:
              monthName = "JUL";
              break;
              case 8:
              monthName = "AUG";
              break;
              case 9:
              monthName = "SEP";
              break;
              case 10:
              monthName = "OCT";
              break;
              case 11:
              monthName = "NOV";
              break;
              case 12:
              monthName = "DEC";
              break;
    }
    return monthName;
}






        private void defineSeries()
        {
            chtRoom.Series.Clear();
            chtRoom.Series.Add("Bookings");

            chtRoom.Series["Bookings"].ChartType = SeriesChartType.Column;
            chtRoom.Series["Bookings"].XValueType = ChartValueType.String;
        }


        private void defineChart(string year)
        {
            //define chart
            chtRoom.Size = new Size(720, 330);
            chtRoom.ChartAreas[0].Name = "mainArea";
            chtRoom.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtRoom.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtRoom.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtRoom.ChartAreas["mainArea"].AxisY.Interval = 1;
            chtRoom.ChartAreas["mainArea"].AxisY.Title = "Times Booked";

            chtRoom.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtRoom.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtRoom.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            
            chtRoom.Titles.Clear();
            chtRoom.Titles.Add("Monthly Sales 20" + year);
        }
    }
}
