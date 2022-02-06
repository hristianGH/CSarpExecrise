using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in Console.ReadLine().Split())
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count.Add(item, 1);
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
