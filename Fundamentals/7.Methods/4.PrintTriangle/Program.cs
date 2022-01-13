using System;

namespace _4.PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int negative;
            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= i && i<=n; y++)
                {
                    Console.Write(y+" ");
                }
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(y + " ");

                }
                Console.WriteLine();

            }
        }
    }
}
