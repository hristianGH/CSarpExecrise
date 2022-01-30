using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dicdic = new Dictionary<char, int>();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                char[] inputToChar = input[i].ToCharArray();
                for (int y = 0; y < inputToChar.Length; y++)
                {
                    if (dicdic.ContainsKey(inputToChar[y]))
                    {
                        dicdic[inputToChar[y]]++;
                    }
                    else
                    {
                        dicdic.Add(inputToChar[y], 1);
                    }
                }
            }
            foreach (var item in dicdic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
