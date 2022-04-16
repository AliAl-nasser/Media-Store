using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Laboration4.Models;

namespace Laboration4.Controllers
{
    public class WarehouseController
    {
        FileProcessor FileProcesspr = new FileProcessor();
        public static List<InventoryProduct> ProductsList { get; set; }
        public static List<Stats> StatList { get; set; }
        DataGridView gridData;
        public Exception execption;

        internal void PopulateGridView(DataGridView dataGrid)
        {
            FileProcesspr.ReadFile("Inventory.csv");
            FileProcesspr.ReadFile("statistics.csv");
            ProductsList = FileProcesspr.GetProductList();
            StatList = FileProcesspr.GetStatList();
            gridData = dataGrid;
            gridData.DataSource = ProductsList;
        }

        public List<InventoryProduct> GetProductList()
        {
            return ProductsList;
        }

        internal void SaveData()
        {
            FileProcesspr.WriteFile("Inventory.csv");
            FileProcesspr.WriteFile("statistics.csv");
        }

        public List<Stats> GetStatList()
        {
            return StatList;
        }

        internal void IncreaseQuantity(uint NewQuantity, uint Id,  uint OldQuantity)
        {
            var product = ProductsList.FirstOrDefault(p => p.Id == Id);
            if (product != null) { product.Quantity = NewQuantity + OldQuantity; }
            UpdateDataGrid();
        }

        public void ProvideData(string monthName, string year, Label monthLabel, Label yearlabel, ListBox topList)
        {
            topList.Items.Clear();
            string Date = year + "-" + monthName;
            var statitems = StatList.Where(StringToCheck => StringToCheck.Date.Equals(Date));
            var matchinngvalue = StatList.Where(StringToCheck => StringToCheck.Date.Contains(year));
            long totalyear = matchinngvalue.Sum(item => item.Amount);
            long totalmonth = statitems.Sum(item => item.Amount);
            yearlabel.Text = "This year: " + totalyear;
            monthLabel.Text = "This month: " + totalmonth;
            var noduplicates = matchinngvalue.GroupBy(d => d.Id)
                 .Select(
                     g => new
                     {
                         g.Key,
                         Amount = g.Sum(s => s.Amount),
                         g.First().Product,
                         g.First().Type
                     });
            var top10 = noduplicates.OrderByDescending(item => item.Amount).Take(10);
            int i = 1;
            foreach (var item in top10 )
            {
                String list = String.Concat(i + ". " + item.Product + " (" + item.Type + "), " + "Amount: " + item.Amount);
                topList.Items.Add(list);
                i++;
            }
        }

        internal void AddItem(string id, string nameofProduct, string price, string type, string quantity, string author, string platform, string format, string genre, string playtime, string language)
        {
            try
            {
                ProductType productType = new ProductType();
                if (type == "Book")
                {
                    productType = ProductType.Book;
                }
                else if(type == "Film")
                {
                    productType = ProductType.Film;
                }
                else if (type == "Game")
                {
                    productType = ProductType.Game;
                }
                ProductsList.Add(new InventoryProduct
                {
                    Id = uint.Parse(id),
                    Name = nameofProduct,
                    Price = uint.Parse(price),
                    Type = productType,
                    Quantity = uint.Parse(quantity),
                    Author = author,
                    Platform = platform,
                    Format = format,
                    Genre = genre,
                    PlaytimeInMin = playtime,
                    Language = language
                }); 
            }
            catch (Exception ex)
            {
                execption = ex;
            }
            UpdateDataGrid();
        }

        internal void RemoveItem()
        {
            ProductsList.RemoveAt(gridData.SelectedRows[0].Index);
            UpdateDataGrid();
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
            gridData.DataSource = ProductsList;
        }
    }
}
