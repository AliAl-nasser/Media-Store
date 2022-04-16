using CsvHelper.Configuration.Attributes;

namespace Laboration4.Models
{
    public class Stats
    {
        [Name("Id")]
        public uint Id { get; set; }
        [Name("Product")]
        public string Product { get; set; }
        [Name("Type")]
        public ProductType Type { get; set; }
        [Name("Date")]
        public string Date { get; set; }
        [Name("Amount")]
        public uint Amount { get; set; }
    }
}