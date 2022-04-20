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

        // Instance of WarehouseController to access methods
        WarehouseController WarehouseController = new WarehouseController();
        // Selected month
        public string MonthName;
        // Selected year
        public string Year;

        // Event occurs when user change combobox selected index for month
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthName = (string)comboBox1.SelectedItem;

        }

        // Event occurs when user change combobox selected index for year
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = (string)comboBox2.SelectedItem;
        }

        // Event occurs when user click show button
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
