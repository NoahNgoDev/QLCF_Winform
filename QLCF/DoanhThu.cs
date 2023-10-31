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

namespace QLCF
{
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
            bieudo();
        }

        public void bieudo()
        {
            double[] values = { 10, 20, 15, 30, 125, 90, 10, 20, 15, 30, 125, 90, 34 };
            string[] categories = { "ngày 1", "ngày 2", "ngày 3", "ngày 4", "ngày 5", "ngày 6", "ngày 7", "ngày 8", "ngày 9", "ngày 10", "ngày 11", "ngày 12", "ngày 13" };


            Chart chart1 = new Chart();
            chart1.Size = new Size(700, 600);
            chart1.Location = new Point(20, 153);
            this.Controls.Add(chart1);

            chart1.ChartAreas.Add(new ChartArea("chartArea"));

            Series series = new Series("DataSeries");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);
            chart1.Series["DataSeries"].IsValueShownAsLabel = true;


            //chart1.Titles.Add("Biểu đồ số lượng khách theo tuần");
            

            for (int i = 0; i < values.Length; i++)
            {
                DataPoint point = new DataPoint(i, values[i]);
                point.AxisLabel = categories[i]; // Thiết lập giá trị nằm trên đầu cột
                series.Points.Add(point);
            }

            chart1.ChartAreas["chartArea"].AxisX.Title = "Categories";
            chart1.ChartAreas["chartArea"].AxisY.Title = "Values";
        }

        
    }
}
