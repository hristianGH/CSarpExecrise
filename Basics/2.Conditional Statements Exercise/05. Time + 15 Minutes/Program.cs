using System;
using System.Runtime.InteropServices;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {


            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

               int timeinmin = hour * 60 + min;
            int timeinmin15 = timeinmin + 15;
            int hourAfter15 = timeinmin15 / 60;
            int minAfter15 = timeinmin15 % 60;
            if (hourAfter15==24)
            {
                hourAfter15 = 0;
            }
            if (minAfter15==60)
            {
                minAfter15 = 0;
                hourAfter15 =+1;

            }
            Console.WriteLine($"{hourAfter15}:{minAfter15:d2}");

            

        }
    }
}
