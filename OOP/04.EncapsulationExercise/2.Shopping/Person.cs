using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Shopping
{
    class Person
    {
        public Person(string name,double money)
        {
            Name = name;
            Money = money;
            Products = new List<string>();
        }
        public double Money { get; set; }
        public string Name { get; set; }
        public List<string> Products { get; set; }
    }
}
