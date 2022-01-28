using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numMaxDivision = 0;
            bool divisible = false ;
            if (num%2==0)
            {
                numMaxDivision = 2;
                divisible = true;
            }
            if (num %3==0)
            {
                numMaxDivision = 3;
                divisible = true;

            }
            if (num % 6 == 0)
            {
                numMaxDivision = 6;
                divisible = true;
            }
            if (num % 7 == 0)
            {
                numMaxDivision = 7;
                divisible = true;
            }
            if (num % 10 == 0)
            {
                numMaxDivision = 10;
                divisible = true;
            }


            if (divisible == true)
            {
            Console.WriteLine($"The number is divisible by {numMaxDivision}");

            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
