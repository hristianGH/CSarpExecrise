using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Resturant
{
    class Product
    {
        public Product(string n , double p)
        {
            Name = n;
            Price = p;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
