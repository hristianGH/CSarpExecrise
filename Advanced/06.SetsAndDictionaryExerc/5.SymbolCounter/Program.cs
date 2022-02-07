using System;
using System.Collections.Generic;

namespace _5.SymbolCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dicdic = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (dicdic.ContainsKey(item))
                {
                    dicdic[item]++;
                }
                else
                {
                    dicdic.Add(item, 1);
                }
            }

            foreach (var item in dicdic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
