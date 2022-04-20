using Laboration4.Controllers;
using Laboration4.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public WarehouseView()
        {
            InitializeComponent();
            WarehouseController = new WarehouseController();
        }

        // Event that occurs before the control becomes visible for the first time
        private void UserControlLoad(Object sender, EventArgs e)
        {
            WarehouseController.PopulateGridView(this.InventoryGridView);
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
            if (WarehouseController.API != null)
            {
                MessageBox.Show(WarehouseController.API.ToString());
            }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            WarehouseController.Sync();
        }
    }
}
