using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };
            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day < 8)
            {
                day--;
                Console.WriteLine(daysOfWeek[day]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}

