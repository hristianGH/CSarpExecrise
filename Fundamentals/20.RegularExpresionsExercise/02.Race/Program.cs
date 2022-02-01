using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namesToFind = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<Running> names = new List<Running>().OrderByDescending(x => x.Distance).ToList();
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
                if (names.Any(x => x.Name == name))
                {
                    names.Where(x => x.Name == name).ToList().ForEach(x => x.Distance += distance);

                }
                else  
                {
                    var newName = new Running(name, distance);
                    names.Add(newName);

                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"1st place: {names[0].Name}");
            Console.WriteLine($"2nd place: {names[1].Name}");
            Console.WriteLine($"3rd place: {names[2].Name}");
            foreach (var item in names)
            {
                Console.WriteLine($"{item.Distance} {item.Name}");
            }
        }
    }
}
class Running
{
    public Running(string n, int d)
    {
        Name = n;
        Distance = d;
    }
    public string Name { get; set; }
    public int Distance { get; set; }
}