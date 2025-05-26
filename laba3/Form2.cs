using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SetupChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Год";
            chart1.ChartAreas[0].AxisY.Title = "Цена (млн руб.)";
        }

        private void UpdateChart(List<HousingPrice> prices, string apartmentType)
        {
            chart1.Series.Clear();
            var series = new Series(apartmentType)
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2
            };

            foreach (var price in prices)
            {
                double value = 0;
                switch (apartmentType)
                {
                    case "1-комн.": value = price.OneRoomPrice; break;
                    case "2-комн.": value = price.TwoRoomPrice; break;
                    case "3-комн.": value = price.ThreeRoomPrice; break;
                }
                series.Points.AddXY(price.Year, value);
            }

            chart1.Series.Add(series);
        }
    }
}
