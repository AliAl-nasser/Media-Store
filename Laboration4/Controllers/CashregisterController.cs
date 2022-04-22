using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Laboration4.Models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Laboration4.Controllers
{
    public class CashregisterController
    {
        // Instance of class WarehouseController to call methods
        WarehouseController warehouseController = new WarehouseController();
        // Creates list of products
        static public List<InventoryProduct> ProductsList = new List<InventoryProduct>();
        // creates list of stats
        static public List<Stats> StatList = new List<Stats>();
        // creates list of shopping cart items
        static public List<ShoppingCartItem> CartList = new List<ShoppingCartItem>();
        // DataGridViews for binding and updating the views
        DataGridView gridData;
        DataGridView gridData1;
        // creates list of shopping cart item for repurchase
        static public List<ShoppingCartItem> TempCart = new List<ShoppingCartItem>();

        // Populates the datagridviews and provide source for them
        internal void PopulateGridView(DataGridView dataGrid, DataGridView dataGrid1)
        {
            ProductsList = warehouseController.GetProductList();
            StatList = warehouseController.GetStatList();
            gridData = dataGrid;
            gridData1 = dataGrid1;
            gridData.DataSource = ProductsList;
            var bindinglist = new List<ShoppingCartItem>(CartList);
            var source = new BindingSource(bindinglist, null);
            gridData1.DataSource = source;
        }

        // Searches for attributes such as Name, Author, Type or Quantity in productlist
        internal void Search(TextBox textBox)
        {
            var results = ProductsList.Where(p => p.Name == textBox.Text || p.Author == textBox.Text || p.Type.ToString() == textBox.Text || p.Quantity.ToString() == textBox.Text).ToList();
            if (String.IsNullOrEmpty(textBox.Text))
            {
                UpdateDataGrid();
            }
            else if (results.Count != 0)
            {
                gridData.DataSource = results;
            }
        }

        // Updates datasource for products datagridview
        internal void UpdateDataGrid()
        {
            gridData.DataSource = null;
            gridData.DataSource = warehouseController.GetProductList();
        }

        // Updates datasource for shopping cart datagridview
        internal void UpdateCartGrid()
        {
            gridData1.DataSource = null;
            gridData1.DataSource = CartList;
        }

        // Adds a new product to shopping cart, if the product already exists in the shopping cart the the quantity will increase by 1
        internal void AddToCart(uint Id)
        {
            var product = ProductsList.FirstOrDefault(p => p.Id == Id);
            if (product != null) { product.Quantity--; }
            if (CartList.Any(p => p.Id == Id))
            {
                var Item = CartList.FirstOrDefault(p => p.Id == Id);
                if (Item != null) { Item.Quantity ++; }
            }
            else
            {
                CartList.Add(new ShoppingCartItem
                {
                    Id = Id,
                    Name = product.Name,
                    Price = product.Price,
                    Type = product.Type,
                    Quantity = 1,
                });
            }
            UpdateCartGrid();
            UpdateDataGrid();
        }

        // Repurchase all items i tempcart list and updates the quantity for product in productlist
        internal void Repurchase()
        {
           if(TempCart.Count != 0)
            {
                foreach (var item in TempCart)
                {
                    StatList.RemoveAt(StatList.Count - 1);
                   var product = ProductsList.FirstOrDefault(p => p.Id == item.Id);
                    if (product != null) { product.Quantity += item.Quantity; }
                }
                TempCart.Clear();
                UpdateDataGrid();
            }
        }

        // Removes a product from shoppin cart,  if the product has a quantity larger than 1 then the quantity will decrease by 1
        internal void RemoveItem(uint Id)
        {
            var Item = CartList.FirstOrDefault(p => p.Id == Id);
            if (Item != null)
            {
                if (ProductsList.Any(p => p.Id == Id))
                {
                    var Product = ProductsList.FirstOrDefault(p => p.Id == Id);
                    if (Product != null) { Product.Quantity += Item.Quantity; }
                }
                CartList.RemoveAt(gridData1.SelectedRows[0].Index);
                UpdateDataGrid();
                UpdateCartGrid();
            }
        }

        // Removes all products in the shopping cart and updates quantity in inventory
        internal void RemoveAll()
        {
            foreach(var item in CartList)
            {
                var product = ProductsList.FirstOrDefault(p => p.Id == item.Id);
                if (product != null) { product.Quantity += item.Quantity;  }
            }
            CartList.Clear();
            UpdateCartGrid();
            UpdateDataGrid();
        }

        // Selling the products in the shopping cart and providing receipt
        internal void Checkout()
        {
            string Month = DateTime.Now.ToString("MMMM");
            string Date = DateTime.Now.Year.ToString() +"-"+ char.ToUpper(Month[0])+Month.Substring(1);
            string FileName = "receipt.pdf";
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Receipt for order";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            XFont fon1 = new XFont("Verdana", 13, XFontStyle.Regular);
            gfx.DrawString("Receipt:", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
            int y = 50;
            uint total = 0;
            foreach (var item in CartList)
            {
                total += item.Price * item.Quantity;
                string line = "Name: " + item.Name.ToString() + ", Price: " + item.Price.ToString() + ", Type: " + item.Type.ToString() + ", Quantity: " + item.Quantity.ToString();
                gfx.DrawString(line, fon1, XBrushes.Black, 0, y);
                y += 50;
                TempCart.Add(item);
                StatList.Add(new Stats
                {
                    Id = item.Id,
                    Product = item.Name,
                    Type = item.Type,
                    Date = Date,
                    Amount = item.Quantity
                });
            }
            gfx.DrawString( "Total: " + total.ToString(), fon1, XBrushes.Black, 0, y);
            CartList.Clear();
            UpdateCartGrid();
            document.Save(FileName);
            Process.Start(FileName);
            WarehouseController.Sync();
        }
    }
}
