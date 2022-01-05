using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            while (true)
            { 
               // Console.WriteLine("Destination?");

                string destination = Console.ReadLine();


                if (destination=="End")
                {
                    break;
                }
                // Console.WriteLine("Money?");
                int moneyNeed = int.Parse(Console.ReadLine());

                while (true)
                {
                   // Console.WriteLine("Add Value...");
                if (money>=moneyNeed)
                {
                    money -= moneyNeed;
                     Console.WriteLine($"Going to {destination}!");
                        break;
                }
                    else
                    {
                    int addmoney = int.Parse(Console.ReadLine());
                    money += addmoney;

                    }
                }

            }

        }

    }
}
