using System;

namespace _2.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(";");
            Person[] people = new Person[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                if (split[0] == "")
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);

                }
                else if (double.Parse(split[1]) < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);

                }
                else
                {
                    people[i] = new Person(split[0], double.Parse(split[1]));
                }
            }
            input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            Product[] products = new Product[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split("=");
                if (split[0] == "")
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);

                }
                else if (double.Parse(split[1]) < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
                else
                {
                    products[i] = new Product(split[0], double.Parse(split[1]));
                }
            }
            input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                foreach (var person in people)
                {
                    if (input[0] == person.Name)
                    {
                        foreach (var product in products)
                        {
                            if (input[1] == product.Name)
                            {
                                if (person.Money - product.Price > -1)
                                {
                                    person.Money -= product.Price;
                                    person.Products.Add(product.Name);
                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't affort {product.Name}");
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            foreach (var item in people)
            {
                if (item.Products.Count < 1)
                {
                    Console.WriteLine($"{item.Name} - nothing bought");
                }
                else
                {

                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Products)}");
                }
            }
        }
    }
}
