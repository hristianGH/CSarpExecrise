using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> city =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();
                if (city.ContainsKey(array[0])) //continent
                {
                    if (city[array[0]].ContainsKey(array[1]))//city
                    {
                        city[array[0]][array[1]].Add(array[2]);
                    }
                    else
                    {
                        city[array[0]].Add(array[1], new List<string>() { array[2] });
                    }
                }
                else
                {
                    city.Add(array[0], new Dictionary<string, List<string>>());
                    city[array[0]].Add(array[1], new List<string>() {array[2]});
                }
            }
            foreach (var item in city)
            {
                Console.WriteLine($"{item.Key}:");
                
                foreach (var itemTwo in item.Value)
                {
                    Console.Write($"{itemTwo.Key} -> ");
                    Console.WriteLine(string.Join(", ",itemTwo.Value));
                    
                }
            }
        }
    }
}

 