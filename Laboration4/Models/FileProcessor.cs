using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Laboration4.Models
{
    public class FileProcessor
    {
 
        static public List<InventoryProduct> ProductsList;
        static public List<Stats> StatList;
        public void ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName, Encoding.UTF8))
            using (var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                if(fileName == "Inventory.csv")
                {
                    ProductsList = csv.GetRecords<InventoryProduct>().ToList();
                    reader.Close();
                }
                else if(fileName == "statistics.csv")
                {

                    StatList = csv.GetRecords<Stats>().ToList();
                    reader.Close();
                }
            }
           
        }

        public List<InventoryProduct> GetProductList()
        {
            return ProductsList;
        }

        public List<Stats> GetStatList()
        {
            return StatList;
        }

        public void WriteFile(string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            using (var cvs = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
            {
                if(fileName == "Inventory.csv")
                {
                    cvs.WriteRecords(GetProductList());
                }
                else if(fileName == "statistics.csv")
                {
                    cvs.WriteRecords(GetStatList());
                }
            }
        }
    }
}
