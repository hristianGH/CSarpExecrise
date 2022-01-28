using System;
using System.Collections.Generic;

namespace _03.Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dicdic = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();
                if (dicdic.ContainsKey(inputOne))
                {
                    dicdic[inputOne].Add(inputTwo);
                }
                else
                {
                    dicdic.Add(inputOne, new List<string>());
                    dicdic[inputOne].Add(inputTwo);

                }


            }
            foreach (var item in dicdic)
            {
                Console.Write($"{item.Key} - {string.Join(", ",item.Value)}");
                
                Console.WriteLine();
            }
        }
    }
}
 