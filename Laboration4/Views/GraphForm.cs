using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboration4.Views
{
    public partial class GraphForm : Form
    {
        public List<uint> Price { get; set; }
        public List<uint> Stocks { get; set; }
        public List<DateTime> Dates { get; set; }
        public GraphForm(List<uint> price, List<uint> stocks, List<DateTime> dates)
        {
            InitializeComponent();
            Price = price;
            Stocks = stocks;
            Dates = dates;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
