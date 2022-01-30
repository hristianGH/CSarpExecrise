using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dicdic = new Dictionary<string, List<string>>();
            string[] inputarr = Console.ReadLine().Split(" ->", StringSplitOptions.RemoveEmptyEntries);
            while (inputarr[0] != "End")
            {
                string name = inputarr[0];
                string code = inputarr[1];

                if (dicdic.ContainsKey(name))
                {
                    if (dicdic[name].Contains(code) == false)
                    {

                        dicdic[name].Add(code);
                    }

                }
                else
                {
                    dicdic.Add(name, new List<string> { code });
                }

                inputarr = Console.ReadLine().Split(" ->", StringSplitOptions.RemoveEmptyEntries);

            }
            foreach (var item in dicdic.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"--{name}");
                }
            }
        }
    }
}
