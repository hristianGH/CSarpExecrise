using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":

                    if (hour <= 18 && hour >= 10)
                    {
                        Console.WriteLine("Open");
                    }
                    else
                    {
                        Console.WriteLine("Closed");
                    }
                    break;
                default:
                    Console.WriteLine("Closed");
                    break;
            }
        }
    }
}
