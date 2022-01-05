using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                 a = b + a;
            }

            Console.WriteLine(a);

        }

    }
}
