using System;

namespace USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double value = 0;
            string endCurrency = "";
            Console.WriteLine("Press y for USD");
            Console.WriteLine("Press n for BGN");
            if (Console.ReadKey().KeyChar == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("Enter USD");
                value = double.Parse(Console.ReadLine());
                value = value * 1.79549;
                endCurrency = "BGN";
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter BGN");
                value = double.Parse(Console.ReadLine());
                value = value / 1.79549;
                endCurrency = "USD";
            }
            Console.WriteLine(value);
        }
    }
}
//1 USD = 1.79549 BGN