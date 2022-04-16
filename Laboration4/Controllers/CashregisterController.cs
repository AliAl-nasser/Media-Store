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
        WarehouseController warehouseController = new WarehouseController();
        static public List<InventoryProduct> ProductsList = new List<InventoryProduct>();
        static public List<Stats> StatList = new List<Stats>();
        static public List<ShoppingCartItem> CartList = new List<ShoppingCartItem>();
        DataGridView gridData;
        DataGridView gridData1;
        static public List<ShoppingCartItem> TempCart = new List<ShoppingCartItem>();

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

        internal void UpdateDataGrid()
        {
            gridData.DataSource = null;
            gridData.DataSource = warehouseController.GetProductList();
        }

        internal void UpdateCartGrid()
        {
            gridData1.DataSource = null;
            gridData1.DataSource = CartList;
        }
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
        }
    }
}
