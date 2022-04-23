using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laboration4.Views
{
    public partial class PriceGraph : Form
    {
        public List<uint> Prices { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Names { get; set; }

        public PriceGraph(List<uint> prices, List<DateTime> dates, List<string> names)
        {
            InitializeComponent();
            Prices = prices;
            Dates = dates;
            Names = names;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Names.Count; i++)
            {
                foreach (Series series in chart1.Series)
                {
                    if(series.Name == Names[i])
                    {
                        series.Points.AddXY(Dates[i], Prices[i]);
                    }
                }
            }
        }
    }
}
