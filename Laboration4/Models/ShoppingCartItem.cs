using CsvHelper.Configuration.Attributes;

namespace Laboration4.Models
{
    public class ShoppingCartItem
    {

        [Name("Id")]
        public uint Id { get; set; }
        [Name("Name")]
        public string Name { get; set; }
        [Name("Price")]
        public uint Price { get; set; }
        [Name("Type")]
        public ProductType Type { get; set; }
        [Name("Quantity")]
        public uint Quantity { get; set; }
    }
}
