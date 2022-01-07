using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxCap = 255;
            int present = 0;
               int counter = 0;
            while (n>counter)
            {
                int add = int.Parse(Console.ReadLine());
                present = present + add;
                if (present>maxCap)
                {
                    Console.WriteLine("Insufficient capacity!");
                    present -= add;
                }
                counter ++ ;
                add = 0;
            }
                Console.WriteLine(present);
        }
    }
}
