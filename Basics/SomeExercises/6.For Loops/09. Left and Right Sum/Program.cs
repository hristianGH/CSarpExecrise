using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("2");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int sumOne = a + b;
            int sumTwo = c + d;
            int sumIfMinus = (sumOne-sumTwo) * (-1);
            if (sumOne==sumTwo)
            {
                Console.WriteLine($"Yes, sum = {sumTwo}");
            }
            else if (sumOne!=sumTwo)
            {
                if (sumOne-sumTwo <0)
                {
                     Console.WriteLine($"No, diff = {sumIfMinus}");

                }
                else
                {
                  Console.WriteLine($"No, diff = {sumOne-sumTwo}");

                }
            }
            //
        
        }
    }
}
