using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dicdic = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input!="stop")
            {
                int n = int.Parse(Console.ReadLine());
                if (dicdic.ContainsKey(input))
                {
                    dicdic[input] += n;
                }
                else
                {
                    dicdic.Add(input, n);
                }
                input = Console.ReadLine();
            }
                foreach (var item in dicdic)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
        }
    }
}
