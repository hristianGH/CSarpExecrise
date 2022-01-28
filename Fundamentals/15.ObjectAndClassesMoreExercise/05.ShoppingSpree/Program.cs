using System;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';');

            foreach (var person in peopleInput)
            {
                string[] parts = person.Split('=');
                string name = parts[0];
                double money = double.Parse(parts[1]);
                people.Add(new Person(name, money));
            }

            string[] productsInput = Console.ReadLine().Split(';');

            foreach (var product in productsInput)
            {
                string[] parts = product.Split('=');
                string name = parts[0];
                double cost = double.Parse(parts[1]);
                products.Add(new Product(name, cost));
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split(' ');
                string personName = parts[0];
                string productName = parts[1];

                people.Find(p => p.Name == personName).BuyProduct(products.Find(p => p.Name == productName));
            }


            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }
        public string Name { get; set; }

        public double Money { get; set; }

        public List<string> Products { get; set; }

        public void BuyProduct(Product product)
        { 
            if (this.Money >= product.Cost)
            {
                this.Products.Add(product.Name);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
    class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
