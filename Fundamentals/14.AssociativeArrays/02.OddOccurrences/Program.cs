using System;
using System.Collections.Generic;
using System.Text;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dicdic = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                string toLower = item.ToLower();
                if (dicdic.ContainsKey(toLower))
                {
                    dicdic[toLower]++;
                }
                else
                {
                    dicdic.Add(toLower, 1);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in dicdic)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }

        }
    }
}
