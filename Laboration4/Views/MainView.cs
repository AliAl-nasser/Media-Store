using Laboration4.Controllers;
using System;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WarehouseView warehouse = new WarehouseView
            {
                Dock = DockStyle.Fill
            };
            WarehouseTab.Controls.Add(warehouse);
            CashregisterView cashregister = new CashregisterView
            {
                Dock = DockStyle.Fill
            };
            CashregisterTab.Controls.Add(cashregister);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        public void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            WarehouseController warehouseController = new WarehouseController();
            warehouseController.SaveData();
        }
    }
}
