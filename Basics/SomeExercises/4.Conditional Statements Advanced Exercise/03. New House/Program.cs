using System;
using System.Threading;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double rosePrice = 5.00;
            double dahliasPrice = 3.80;
            double tylipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;
            //
            string typeFlower = Console.ReadLine();
            int numFlower = int.Parse(Console.ReadLine());
            int budghet = int.Parse(Console.ReadLine());
            double flowerSum = 0.00;
            //

            if (typeFlower == "Roses")
            {
                flowerSum = rosePrice * numFlower;
                if (numFlower >= 80)
                {
                    flowerSum *= 0.90;
                }

            }

            else if (typeFlower == "Dahlias")
            {
                flowerSum = dahliasPrice * numFlower;
                if (numFlower >= 90)
                {
                    flowerSum *= 0.85;

                }
            }

            else if (typeFlower == "Tulips")
            {
                flowerSum = tylipsPrice * numFlower;
                if (numFlower >= 80)
                {
                    flowerSum *= 0.85;
                }
            }

            else if (typeFlower == "Narcissus")
            {
                flowerSum = narcissusPrice * numFlower;
                if (numFlower <= 120)
                {
                    flowerSum *= 1.15;
                }
            }

            else if (typeFlower == "Gladiolus")
            {
                flowerSum = gladiolusPrice * numFlower;
                if (numFlower <= 80)
                {
                    flowerSum *= 1.20;
                }
            }
                if(flowerSum<budghet)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlower} {typeFlower} and {budghet-flowerSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {flowerSum-budghet:f2} leva more.");
            }
        }
    }
}
