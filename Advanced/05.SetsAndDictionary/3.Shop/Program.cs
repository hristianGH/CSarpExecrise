using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Shop
{
    class Program
    {
        static void Main(string[] args)
        {   //Shop,Product,Price
            //name,product,price
            List<ShopClass> listShops = new List<ShopClass>();
            
            string[] input = Console.ReadLine().Split(", ");
            while (input[0]!="Revision")
            {
                if (listShops.Any(x=>x.Shop.Contains(input[0])))
                {
                    int index = listShops.FindIndex(x => x.Shop == input[0]);
                    listShops[index].ProductPrice.Add(input[1], double.Parse(input[2]));
                }
                else
                {
                    ShopClass newShop = new ShopClass(input[0], input[1], double.Parse(input[2]));
                    listShops.Add(newShop);
                }
                input = Console.ReadLine().Split(", ");

            }
            foreach (var item in listShops.OrderBy(x=>x.ProductPrice.Count()).Reverse())
            {
                Console.WriteLine($"{item.Shop}->");
                foreach (var itemTwo in item.ProductPrice)
                {
                    Console.WriteLine($"Prouct: {itemTwo.Key}, Price: {itemTwo.Value}");
                }
            }
        }
    }
}
class ShopClass
{
    public ShopClass(string name,string product,double price)
    {
        Shop = name;
        Dictionary<string, double> Product = new Dictionary<string, double>();
        Product.Add(product, price);
        ProductPrice = Product;
    }
    public string Shop { get; set; }
    public Dictionary<string,double> ProductPrice { get; set; }
    
}
