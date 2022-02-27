using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InStock
{
    class Stock
    {
        List<Product> Products { get; set; }
        public void Add(Product ass)
        {
            Products.Add(ass);
        }
        public void Contains(Product product)
        {
            foreach (var item in Products)
            {
                if (product.Label == item.Label)
                {

                }
            }
        }
        public int Count()
        {

            return Products.Count;
        }
        public Product Find(int index)
        {
            if (Products[index] != null)
            {
                return Products[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Product FindByLabel(string label)
        {

            foreach (var item in Products)
            {
                if (label == item.Label)
                {
                    return item;
                }

            }
            throw new ArgumentException();
        }
        public Product[] FindAllInPriceRange(decimal one, decimal two)
        {
            List<Product> prods = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Price >= one && item.Price <= two)
                {
                    prods.Add(item);
                }
            }
            if (prods.Count > 0)
            {
                prods.Reverse();
                    return prods.ToArray();
            }
            else
            {
                return prods.ToArray();
            }
        }
        public Product[] FindAllByPrice(decimal price)
        {
            List<Product> thisPrice = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Price==price)
                {
                    thisPrice.Add(item);
                }
            }
            return thisPrice.ToArray();
        }
        public Product[] MostExpensiveProducts(int num)
        {
            Product[] products = new Product[num];

            List<Product> ordered = Products.OrderBy(x => x.Price).Reverse().ToList();
            for (int i = 0; i <= num; i++)
            {
                products[i] = ordered[i];
            }
            return products ;
        }
        public Product[] FindByQuantity(int quantity)
        {
            List<Product> products = new List<Product>();
            foreach (var item in Products.Where(x=>x.Quantity==quantity))
            {
                products.Add(item);
            }
            return products.ToArray();
        }
    }
}
