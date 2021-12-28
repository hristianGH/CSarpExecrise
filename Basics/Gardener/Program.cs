using System;

namespace Gardener
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sqrGardened = double.Parse(Console.ReadLine());
            double dds = 7.61;
            double discount = 0.18;
            sqrGardened=(sqrGardened*dds)-(sqrGardened*discount);
        }
    }
}
