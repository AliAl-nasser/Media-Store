using CsvHelper.Configuration.Attributes;

namespace Laboration4.Models
{
    public class InventoryProduct
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
        [Name("Author")]
        public string Author { get; set; }
        [Name("Platform")]
        public string Platform { get; set; }
        [Name("Format")]
        public string Format { get; set; }
        [Name("Genre")]
        public string Genre { get; set; }
        [Name("Playtime(min)")]
        public string PlaytimeInMin { get; set; }
        [Name("Language")]
        public string Language { get; set; }

    }
    public enum ProductType
    {
        Book,
        Game,
        Film
    }
}
