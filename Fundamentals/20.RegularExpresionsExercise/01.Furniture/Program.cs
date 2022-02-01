using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            string filterInt = @">>(\w+)<<([\d]+)[\!]([\d]+)";
            string filterDouble = @">>(\w+)<<([\d]+\.[\d]+)\!([\d]+)";
            double price=0, sum=0;
            int amount=0;
            List<string> bought = new List<string>();

            while (input != "Purchase")
            {
                var matchInt = Regex.Match(input,filterInt);
               var matchDouble = Regex.Match(input, filterDouble);
                if (matchInt.Success)
                {
                    price=  double.Parse(matchInt.Groups[2].ToString());
                    amount = int.Parse(matchInt.Groups[3].ToString());
                    bought.Add(matchInt.Groups[1].ToString());
                    sum += price * amount;
                }
                else if (matchDouble.Success)
                {
                    price = double.Parse(matchDouble.Groups[2].ToString());
                    amount = int.Parse(matchDouble.Groups[3].ToString());
                    bought.Add(matchDouble.Groups[1].ToString());
                    sum += price * amount;
                }
                  input = Console.ReadLine().Trim();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in bought)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
