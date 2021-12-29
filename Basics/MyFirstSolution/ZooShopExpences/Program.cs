using System;

namespace ZooShopExpences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string command = Console.ReadLine();
            while (command.ToLower()!="end")
            {
                sum+=double.Parse(Console.ReadLine());
                command = Console.ReadLine();
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
