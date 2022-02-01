using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.RaceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesToFind = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<Runner> runners = new List<Runner>();
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                int distance = 0;
                string name = Regex.Replace(input, @"[\W\s\d]", "");
                string replaceDistance = Regex.Replace(input, @"[\D]", "");
                for (int i = 0; i < replaceDistance.Length; i++)
                {
                    distance += int.Parse(replaceDistance[i].ToString());

                }
                if (namesToFind.Contains(name))
                {

                    if (runners.Any(x => x.Name == name))
                    {
                        runners.Where(x => x.Name == name).ToList().ForEach(x => x.Distance += distance);
                    }
                    else
                    {
                        var newName = new Runner(name, distance);
                        runners.Add(newName);

                    }

                }

                input = Console.ReadLine();
            }
            int t = 0;
            foreach (var item in runners.OrderByDescending(x => x.Distance))
            {
                if (t == 0)
                {
                    Console.WriteLine($"1st place: {item.Name}");
                }
                if (t == 1)
                {
                    Console.WriteLine($"2nd place: {item.Name}");
                }
                if (t == 2)
                {
                    Console.WriteLine($"3rd place: {item.Name}");
                }
                t++;
            }
        }
    }
}
class Runner
{
    public Runner(string name, int distance)
    {
        Name = name;
        Distance = distance;
    }

    public string Name { get; set; }
    public int Distance { get; set; }
}