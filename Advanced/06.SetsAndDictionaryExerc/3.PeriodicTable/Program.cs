using System;
using System.Collections.Generic;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    set.Add(item);

                }
            }
         
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
