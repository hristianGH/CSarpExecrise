using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PiramidScheme(n);
        }

        static void PiramidScheme(int n)
        {

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                if (i > 0)
                {
                    Console.WriteLine();
                }
            }
            for (int i =n-1; i > 0 ; i--)
            {
                 for (int j = 1; j <=i; j++)
                 {
                     Console.Write(j+" ");
                 }
                Console.WriteLine();
            }
        }
    }
}
