using Laboration4.Controllers;
using System;
using System.Windows.Forms;

namespace Laboration4.Views
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        WarehouseController WarehouseController = new WarehouseController();
        public string MonthName;
        public string Year;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthName = (string)comboBox1.SelectedItem;

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = (string)comboBox2.SelectedItem;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MonthName) && !String.IsNullOrEmpty(Year))
            {
                WarehouseController.ProvideData(MonthName, Year, MonthLabel, Yearlabel, TopList);
            }
            else
            {
                MessageBox.Show("Pleas provide month and year.");
            }
        }
    }
}
