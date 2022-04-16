using Laboration4.Controllers;
using System;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class CashregisterView : UserControl
    {
        CashregisterController CashregisterController;
        string Id;
        string ItemId;
        string CheckId;

        public CashregisterView()
        {
            InitializeComponent();
            CashregisterController = new CashregisterController();
        }

        private void UserControlLoad(Object sender, EventArgs e)
        {
            CashregisterController.PopulateGridView(this.InventoryGridView, this.CartGridView);
        }

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InventoryGridView.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
            }
        }

        private void CartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CartGridView.Rows[e.RowIndex];
                ItemId = row.Cells[0].Value.ToString();
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            CashregisterController.Search(SearchTextbox);
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = InventoryGridView.CurrentRow;
            try
            {
                uint quantity = UInt32.Parse(row.Cells[4].Value.ToString());
                if (quantity != 0) CashregisterController.AddToCart(UInt32.Parse(Id));
                else MessageBox.Show("Out of Stock!");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row.");
            }
        }

        private void RepurchaseButton_Click(object sender, EventArgs e)
        {
            CashregisterController.Repurchase();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartGridView.Rows.Count > 0)
            {
                try
                {
                    if (ItemId == CheckId)
                    {
                        MessageBox.Show("Please pick row");
                    }
                    else
                    {
                        CashregisterController.RemoveItem(UInt32.Parse(ItemId));
                        if (CartGridView.Rows.Count == 0)
                        {
                            CheckId = null;
                            ItemId = null;
                        }
                        else
                        {
                            CheckId = ItemId;
                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Pleas pick row.");
                }
            }
            else
            {
                MessageBox.Show("Shopping cart empty!");
            }
        }

        private void RemoveCartButton_Click(object sender, EventArgs e)
        {
            if (CartGridView.Rows.Count > 0)
            {
                CashregisterController.RemoveAll();
                CheckId = null;
                ItemId = null;
            }
            else
            {
                MessageBox.Show("Shopping cart empty!");
            }

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (CartGridView.Rows.Count > 0)
            {
                CashregisterController.Checkout();
                CheckId = null;
                ItemId = null;
            }
            else
            {
                MessageBox.Show("Shopping cart empty!");
            }
        }
    }
}
