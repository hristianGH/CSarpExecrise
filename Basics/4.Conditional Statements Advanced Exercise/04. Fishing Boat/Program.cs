using System;
using System.Threading;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishers = int.Parse(Console.ReadLine());
            double sum = 0.00;
            //
            if (season == "Spring")
            {
                sum = sum + 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                sum = sum + 4200;
            }
            else if (season == "Winter")
            {
                sum = sum + 2600;
            }

            if (numFishers <= 6)
            {
                sum = sum * 0.90;
            }
            else if (numFishers >=7 && numFishers<=11)
            {
                sum = sum * 0.85;
            }
            else if (numFishers >12  )
            {
                sum = sum * 0.75;
            }
            
             if (numFishers % 2 == 0 && season != "Autumn")
            {
                sum = sum *0.95;
            }

             if (groupBudget>=sum)
            {
                Console.WriteLine($"Yes! You have {groupBudget-sum:f2} leva left.");
            }
             else
            {
                Console.WriteLine($"Not enough money! You need {sum-groupBudget:f2} leva.");
            }
        }
    }
}
