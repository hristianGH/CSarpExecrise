using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dicdic = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (dicdic.ContainsKey(name))
                {
                    dicdic[name].Add(grade);
                }
                else
                {
                    dicdic.Add(name, new List<double> { grade });
                }
            }
            
            foreach (var item in dicdic.Where(x=>x.Value.Average()>=4.50).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");

            }
        }
    }
}
