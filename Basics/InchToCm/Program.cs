using System;

namespace InchToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Inches");
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine($"{input*2.54} cm");

            }
        }
    }
}
