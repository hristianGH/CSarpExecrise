using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int, int> num = new Dictionary<int, int>();
            foreach (var numer in arr)
            {
                if (num.ContainsKey(numer))
                {
                    num[numer]++;
                }
                else
                {
                    num.Add(numer, 1);
                }
            }
            foreach (var item in num)
            {
            Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
