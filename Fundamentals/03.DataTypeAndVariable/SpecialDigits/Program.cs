using System;

namespace SpecialDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"{i:d1}");
            }

        }
    }
}
