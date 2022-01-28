using System;

namespace _6.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetArea(width, height));

        }
        static double GetArea(double wd,double ht)
        {
            return wd * ht;
        }
    }
}
