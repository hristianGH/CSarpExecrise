using System;

namespace MtoKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            double km = metres * 0.001;
            Console.WriteLine($"{km:F2}");
        }
    }
}
