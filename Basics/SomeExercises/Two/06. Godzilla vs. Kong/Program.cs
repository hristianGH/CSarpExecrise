using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceCostumesPerStatist = double.Parse(Console.ReadLine());
            double costumesPrice = priceCostumesPerStatist * statist;
            double decoration = budget * 0.10;
            if (statist>=150)
            {
                costumesPrice = costumesPrice * 0.9;
            }
            double decoreAndCostumes = decoration + costumesPrice;
            if (decoreAndCostumes > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decoreAndCostumes - budget:f2} leva more.");

               
            }
            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - decoreAndCostumes:f2} leva left.");
            }
        }
    }
}
