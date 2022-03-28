namespace SiteX.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public bool IsSoldOut { get; set; }
        public TypeProd TypeProduct { get; set; }
    }
    public enum TypeProd
    {
        Shoes,
        Shirt,
        Pants,
        Tshirts,
        Socks,
    }
}
