using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laboration4.Views
{
    public partial class StockGraph : Form
    {
        public List<uint> Stocks { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Names { get; set; }

        public StockGraph(List<uint> stocks, List<DateTime> dates, List<string> names)
        {
            InitializeComponent();
            Stocks = stocks;
            Dates = dates;
            Names = names;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Names.Count; i++)
            {
                foreach (Series series in chart2.Series)
                {
                    if (series.Name == Names[i])
                    {
                        series.Points.AddXY(Dates[i], Stocks[i]);
                    }
                }
            }
        }
    }
}
