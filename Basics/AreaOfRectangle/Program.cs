using System;

namespace AreaOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area size is {a*b}");
        }
    }
}
