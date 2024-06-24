using shoppingApp.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace shoppingApp.Forms
{
    public partial class statisticForm : Form
    {
        public statisticForm()
        {
            InitializeComponent();
        }

        private sqlAdapter sql = new sqlAdapter();
        common comm = new common();

        // Form load event
        private void statisticForm_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int month = currentTime.Month;
            int year = currentTime.Year;

            cbBoxMonth.SelectedIndex = month - 1;
            txtYear.Text = year.ToString();

            loadDataStatistic();
            loadDataLineChart();
        }

        // Load data for line chart
        private void loadDataLineChart()
        {
            // X axis
            int[] x = Enumerable.Range(1, 12).ToArray();

            // Y axis
            int[] y = new int[x.Length];


            foreach (int i in x)
            {
                y[i - 1] = sql.getTotalOfAllOrdersByMonthAndYear(i, DateTime.Now.Year) / 1000;
            }

            chart.Series[0].LegendText = "Revenue";
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Points.DataBindXY(x, y);
            chart.Series[0].Color = Color.Red;
            chart.Series[0].YValueType = ChartValueType.Int64;

        }

        // load data for statistic
        private void loadDataStatistic()
        {
            int m = cbBoxMonth.SelectedIndex + 1;
            int y = int.Parse(txtYear.Text);

            lbTotal.Text = comm.splitMoneyStr(sql.getTotalOfAllOrdersByMonthAndYear(m, y).ToString());
            lbNumOfProd.Text = sql.getNumOfProductByMonthAndYear(m, y).ToString();
        }

        // Selected index changed event of combo box month
        private void cbBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxMonth.SelectedIndex != -1 && txtYear.Text != string.Empty)
                loadDataStatistic();
        }
    }
}
