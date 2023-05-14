using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3.View.Admin
{
    public partial class Chart : Form
    {
        public Chart(string year)
        {
            InitializeComponent();
            setChart(year);
        }
        public void setChart(string year)
        {
            LbTK.Text = LbTK.Text + year;
            var li = new ManagerBLL().getRevenueByMonthBLL(year);   
            int[] data = new int[12];
            for (int i = 0; i < 12; i++)
            {
                data[i] = li[i];
            }
            renevueChart.Series.Clear();
            renevueChart.Series.Add("VND");
            renevueChart.Series["VND"].ChartType = SeriesChartType.Column;
            for (int i=0; i < 12; i++)
            {
                int dem = i + 1;
                renevueChart.Series["VND"].Points.AddXY("Tháng" + dem , data[i]);
            }

        }
    }
}
