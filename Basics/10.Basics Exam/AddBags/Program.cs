using System;

namespace AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20kg = double.Parse(Console.ReadLine());
            double bagWeight = double.Parse(Console.ReadLine());
            int daysUntilFly = int.Parse(Console.ReadLine());
            int bagCount=int.Parse(Console.ReadLine());
            if (bagWeight<=10)
            {
                priceAbove20kg = priceAbove20kg * 0.8;
            }
            else if (bagWeight>10 && bagWeight <= 20)
            {
                priceAbove20kg = priceAbove20kg * 0.5;
            }
            if (daysUntilFly>30)
            {
                priceAbove20kg += priceAbove20kg * 0.1;

            }
            else if (daysUntilFly>7 && daysUntilFly<=30)
            {
                priceAbove20kg += priceAbove20kg * 0.15;
            }
            else
            {
                priceAbove20kg += priceAbove20kg * 0.4;
            }
            Console.WriteLine($"The total price of bags is: {priceAbove20kg:f2} lv.");
        }
    }
}
