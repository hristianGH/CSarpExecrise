using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x > 0)
                .Reverse()
                .ToList();
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
