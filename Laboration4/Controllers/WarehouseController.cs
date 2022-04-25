using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;
using Laboration4.Models;

namespace Laboration4.Controllers
{
    public class WarehouseController
    {
        // Instance of class FileProcessor to call methods
        FileProcessor FileProcesspr = new FileProcessor();
        // Creates list of products
        public static List<InventoryProduct> ProductsList;
        // Creates list of stats
        public static List<Stats> StatList;
        // DataGridView for binding and updating the view
        DataGridView gridData;
        // Exception catched when adding new product to productlist and displayed in the class WarehouseView
        public Exception execption;
        // Error message from API
        public string API;
        // Populates the datagridview and provide source
        internal void PopulateGridView(DataGridView dataGrid)
        {
            FileProcesspr.ReadFile("Inventory.csv");
            FileProcesspr.ReadFile("statistics.csv");
            ProductsList = FileProcesspr.GetProductList();
            StatList = FileProcesspr.GetStatList();
            gridData = dataGrid;
            gridData.DataSource = ProductsList;
        }

        // Returns productlist
        public List<InventoryProduct> GetProductList()
        {
            return ProductsList;
        }

        // Calls function in FileProcessor that saves the lists to CSV files 
        internal void SaveData()
        {
            FileProcesspr.WriteFile("Inventory.csv");
            FileProcesspr.WriteFile("statistics.csv");
        }

        //Returns statlist
        public List<Stats> GetStatList()
        {
            return StatList;
        }

        // Increases the quantity for selected product
        internal void IncreaseQuantity(uint NewQuantity, uint Id,  uint OldQuantity)
        {
            var product = ProductsList.FirstOrDefault(p => p.Id == Id);
            if (product != null) { product.Quantity = NewQuantity + OldQuantity; }
            UpdateDataGrid();
        }

        // Provides Statistical data for choosen month and year
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

        // Adds new item to productlist
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

        //Updates local products with central warehouse
        internal void UpdateProducts()
        {
            List<uint> ids = new List<uint>();
            List<uint> prices = new List<uint>();
            List<uint> stocks = new List<uint>();
            WebClient client = new WebClient();
            var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            if (doc.InnerXml.Contains("error"))
            {
                API = "Error: " + doc.InnerText;
            }
            else
            {
                foreach (XmlElement elem in doc.FirstChild.ChildNodes)
                {
                    if (elem.Name == "products")
                    {
                        foreach (XmlElement element in elem.ChildNodes)
                        {
                            ids.Add(uint.Parse(element["id"].InnerText));
                            prices.Add(uint.Parse(element["price"].InnerText));
                            stocks.Add(uint.Parse(element["stock"].InnerText));
                            HistoricalData(uint.Parse(element["price"].InnerText), uint.Parse(element["stock"].InnerText), element["name"].InnerText);
                        }
                    }
                }
                for (int i = 0; i < ids.Count; i++)
                {
                    var product = ProductsList.FirstOrDefault(p => p.Id == ids[i]);
                    if (product != null)
                    {
                        product.Price = prices[i];
                        product.Quantity = stocks[i];
                    }
                }
                UpdateDataGrid();
            }
        }


        // Saves the price, stock and name data for all products to an XML file with the current time.
        internal void HistoricalData(uint price, uint stock, string name)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("historicaldata.xml"))
            {
                doc.Load("historicaldata.xml");
            }
            XmlElement root = doc.DocumentElement;
            XmlElement pelem = doc.CreateElement("productdata");
            XmlElement Price = doc.CreateElement("price");
            Price.InnerText = price.ToString();
            XmlElement Stock = doc.CreateElement("stock");
            Stock.InnerText = stock.ToString();
            XmlElement Date = doc.CreateElement("date");
            Date.InnerText = DateTime.Now.ToString();
            XmlElement Name = doc.CreateElement("name");
            Name.InnerText = name;
            pelem.AppendChild(Price);
            pelem.AppendChild(Stock);
            pelem.AppendChild(Date);
            pelem.AppendChild(Name);
            root.AppendChild(pelem);
            doc.Save("historicaldata.xml");
        }

        // Sync local warehouse with central warehouse
        public static void Sync()
        {
            HttpClient client = new HttpClient();
            foreach(var product in ProductsList)
            {
                var values = new Dictionary<string, string>
                {
                { "id", product.Id.ToString() },
                { "stock", product.Quantity.ToString() }
                };
                var content = new FormUrlEncodedContent(values);
                client.PostAsync("https://hex.cse.kau.se/~jonavest/csharp-api/?action=update", content);
            }  
        }

        // Removes item from productlist
        internal void RemoveItem()
        {
            ProductsList.RemoveAt(gridData.SelectedRows[0].Index);
            UpdateDataGrid();
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
            gridData.DataSource = ProductsList;
        }
    }
}
