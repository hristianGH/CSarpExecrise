using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", nums));
                
        }
    }
}
