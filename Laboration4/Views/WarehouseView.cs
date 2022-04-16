using Laboration4.Controllers;
using Laboration4.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class WarehouseView : UserControl
    {
        WarehouseController WarehouseController;
        string OldQuantity;
        string Id;
        List<string> WarehouseIds;
        public WarehouseView()
        {
            InitializeComponent();
            WarehouseController = new WarehouseController();
        }

        private void UserControlLoad(Object sender, EventArgs e)
        {
            WarehouseController.PopulateGridView(this.InventoryGridView);
        }

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InventoryGridView.Rows[e.RowIndex];
                OldQuantity = row.Cells[4].Value.ToString();
                Id = row.Cells[0].Value.ToString();
            }
        }

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

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }


        private void NewDelivery_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(QuantityTextbox.Text))
            {
                uint NewQuantity = UInt32.Parse(QuantityTextbox.Text);
                WarehouseController.IncreaseQuantity(NewQuantity, UInt32.Parse(Id), UInt32.Parse(OldQuantity));
                uint temp = UInt32.Parse(OldQuantity) + NewQuantity;
                OldQuantity = temp.ToString();
            }
        }

        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(QuantityTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                QuantityTextbox.Text = QuantityTextbox.Text.Remove(QuantityTextbox.Text.Length - 1);
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            WarehouseController.Search(SearchTextbox);
        }
    }
}
