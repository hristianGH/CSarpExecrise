using System;
using System.Text.RegularExpressions;

namespace _03.Frick
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                string name = "";
                string product = "";
                int quantity = 0;
                double price = 0;
                double priceBZ = 0;
                var groper = Regex.Matches(input, @"\%([A-Z][a-z]+)\%\<([\w]+)\>([\w]+)?\|([\d]+)\|([A-Z]?[a-z]+)?([\d]+)+([.][\d]+)?\$");
                if (groper.Count != 0)
                {
                    name = groper[0].Groups[1].ToString();
                    product = groper[0].Groups[2].ToString();
                    quantity = int.Parse(groper[0].Groups[4].ToString());
                    price = double.Parse(groper[0].Groups[6].ToString());
                    priceBZ = 0;
                    if (groper[0].Groups[7].Success==true)
                    {
                        priceBZ = double.Parse(groper[0].Groups[7].ToString());
                    }
                    price += priceBZ;
                    total += quantity * price;
                    Console.WriteLine($"{name}: {product} - {price * quantity:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}
