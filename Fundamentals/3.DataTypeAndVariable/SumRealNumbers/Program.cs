using System;

namespace SumRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sumOutside = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                 
                   sumOutside += number;
                
            }
            Console.WriteLine(sumOutside);
        }
    }
}
