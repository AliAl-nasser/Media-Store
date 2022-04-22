using Laboration4.Controllers;
using Laboration4.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Laboration4
{
    public partial class WarehouseView : UserControl
    {
        // Instance of class WarehouseController to access methods
        WarehouseController WarehouseController;
        // Quantity before a new delivery
        string OldQuantity;
        // Id for selected products
        string Id;
        // all ids for the products in Inventory
        List<string> WarehouseIds;
        // Timer
        private Timer timer;
        public WarehouseView()
        {
            InitializeComponent();
            WarehouseController = new WarehouseController();
        }

        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 60000; //in milliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            WarehouseController.UpdateProducts();
        }

        // Event that occurs before the control becomes visible for the first time
        private void UserControlLoad(Object sender, EventArgs e)
        {
            WarehouseController.PopulateGridView(this.InventoryGridView);
            InitTimer();
        }

        // Event that occurs when user click on a row in datagridview for inventory
        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InventoryGridView.Rows[e.RowIndex];
                OldQuantity = row.Cells[4].Value.ToString();
                Id = row.Cells[0].Value.ToString();
            }
        }

        // Events that occurs when user click add product to inventory button
        private void AddButton_Click(object sender, EventArgs e)
        {
            WarehouseIds = new List<string>();
            foreach (DataGridViewRow row in InventoryGridView.Rows)
            {
                WarehouseIds.Add(row.Cells[0].Value.ToString());
            }

            AddItem addItem = new AddItem();
            addItem.GetIdList(WarehouseIds);
            addItem.ShowDialog();
            if (addItem.flag != false)
            {
                WarehouseController.AddItem(addItem.Id, addItem.NameofProduct, addItem.Price, addItem.Type, addItem.Quantity, addItem.Author, addItem.Platform, addItem.Format, addItem.Genre,
                    addItem.Playtime, addItem.Language);
            }

            if (WarehouseController.execption != null)
            {
                MessageBox.Show(WarehouseController.execption.ToString());
            }
        }

        // Event that occurs when user click remove from inventory button
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OldQuantity != "0")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Remove item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WarehouseController.RemoveItem();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (OldQuantity == "0")
            {
                WarehouseController.RemoveItem();
            }

        }
        // Event that occurs when user click statistics button
        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }

        // Event that occurs when user click new delivery button
        private void NewDelivery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Please pick row");
            }
            if (!String.IsNullOrEmpty(QuantityTextbox.Text) && !String.IsNullOrEmpty(Id))
            {
                uint NewQuantity = UInt32.Parse(QuantityTextbox.Text);
                WarehouseController.IncreaseQuantity(NewQuantity, UInt32.Parse(Id), UInt32.Parse(OldQuantity));
                uint temp = UInt32.Parse(OldQuantity) + NewQuantity;
                OldQuantity = temp.ToString();
            }
        }

        // Event that occurs when quantity text changes
        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(QuantityTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                QuantityTextbox.Text = QuantityTextbox.Text.Remove(QuantityTextbox.Text.Length - 1);
            }
        }

        // Event that occurs when search text changes.
        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            WarehouseController.Search(SearchTextbox);
        }

        // Event occurs when user click update products button
        private void UpdateProducts_Click(object sender, EventArgs e)
        {
            WarehouseController.UpdateProducts();
            if (!String.IsNullOrEmpty(WarehouseController.API))
            {
                MessageBox.Show(WarehouseController.API);
            }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            WarehouseController.Sync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("historicaldata.xml"))
            {
                doc.Load("historicaldata.xml");
            }
            List<uint> Prices = new List<uint>();
            List<uint> Stocks = new List<uint>();
            List<DateTime> Dates = new List<DateTime>();
            List<string> Names = new List<string>();
            foreach(XmlElement elem in doc.FirstChild.ChildNodes)
            {
                Prices.Add(uint.Parse(elem["price"].InnerText));
                Stocks.Add(uint.Parse(elem["stock"].InnerText));
                Dates.Add(DateTime.Parse(elem["date"].InnerText));
                Names.Add(elem["name"].InnerText);
            }
            GraphForm form = new GraphForm(Prices, Stocks, Dates, Names);
            form.Show();
        }
    }
}
