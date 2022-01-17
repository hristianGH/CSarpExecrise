using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.gTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            int midpoint = input.Count / 2;
            for (int i = 0; i < midpoint; i++)
            {
                input[i] += input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
