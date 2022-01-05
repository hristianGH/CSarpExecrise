using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCounter = 0;
            int standartCounter = 0;
            int kidCounter = 0;

            while (true)
            {
                string imputNameMovie = Console.ReadLine();
                if (imputNameMovie=="Finish")
                {
                    break;
                }
                int freeSpaces = int.Parse(Console.ReadLine());
                while (freeSpaces>0)
                {
                    string ticket = Console.ReadLine();

                    switch (ticket)
                    {
                        case "student":
                            studentCounter++;
                            break;

                        case "kid":
                            kidCounter++;
                            break;

                        case "standard":
                            standartCounter++;
                            break;

                        default:
                            break;
                    }
                }
            }

        }
    }
}
