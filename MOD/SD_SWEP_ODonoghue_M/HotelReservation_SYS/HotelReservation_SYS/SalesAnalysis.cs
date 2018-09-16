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
    public partial class SalesAnalysis : Form
    {
        public SalesAnalysis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
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
            else
            {
                grpSaleReport.Visible = true;

                chtYear.Show();
                defineChart(cmbYear.Text.Substring(2,2));

                //Define the chart series
                defineSeries();

                //fill Chart
                fillChart(cmbYear.Text.Substring(2, 2));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbSalesReport_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have printed the document");
        }

        private void grpSaleReport_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshing sales Report");
            cmbYear.SelectedIndex = -1;
            grpSaleReport.Visible = false;
        }


        private void fillChart(string year)
        {

            //fill chart
            chtYear.Series["Revenue"].Points.Clear();



            //get data from database
            DataSet ds = new DataSet();
            ds = Reservations.getMonthlyData(ds, year);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))
                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
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
            chtYear.Series.Clear();
            chtYear.Series.Add("Revenue");

            chtYear.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtYear.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void frmYearlyAnalysis_Load(object sender, EventArgs e)
        {
          
        }

        private void defineChart(string year)
        {
            //define chart
            chtYear.Size = new Size(720, 330);
            chtYear.ChartAreas[0].Name = "mainArea";
            chtYear.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtYear.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtYear.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtYear.ChartAreas["mainArea"].AxisY.Interval = 250;
            chtYear.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chtYear.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtYear.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtYear.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;

            chtYear.Titles.Clear();
            chtYear.Titles.Add("Monthly Revenue 20" + year);
        }

        private void chtYear_Click(object sender, EventArgs e)
        {

        }

        private void SalesAnalysis_Load(object sender, EventArgs e)
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
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
