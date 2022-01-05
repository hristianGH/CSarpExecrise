using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                // a = num + a;
                if (b >= num)
                {
                    b = num;
                }
                if (a <= num)
                {
                    a = num;

                }


            }
            Console.WriteLine($"Max number: {a}");
            Console.WriteLine($"Min number: {b}");
        }
    }
}
