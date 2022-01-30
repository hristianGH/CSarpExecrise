using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._1.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createNew = false;
            bool gotLegendary = false;
            Dictionary<string, int> dicdic = new Dictionary<string, int>();
            Dictionary<string, int> dicTrash = new Dictionary<string, int>();
            dicdic.Add("shards", 0);
            dicdic.Add("motes", 0);
            dicdic.Add("fragments", 0);

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (gotLegendary != true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string inputZero = input[i + 1].ToLower();
                    int qntt = int.Parse(input[i]);
                    if (dicdic.ContainsKey(inputZero))
                    {
                        dicdic[inputZero] += qntt;
                        createNew = true;
                    }
                    else if (dicTrash.ContainsKey(inputZero))
                    {
                        dicTrash[inputZero] += qntt;
                        createNew = true;
                    }
                    dicdic.TryGetValue("shards", out int shadow);
                    dicdic.TryGetValue("fragments", out int valanyr);
                    dicdic.TryGetValue("motes", out int dragonwrath);
                    if (shadow > 250)
                    {
                        Console.WriteLine("Shadowmourne obatained!");
                        dicdic["shards"] -= 250;
                        gotLegendary = true;
                        break;
                    }
                    if (valanyr > 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        dicdic["fragments"] -= 250;
                        gotLegendary = true;

                        break;
                    }
                    if (dragonwrath > 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        dicdic["motes"] -= 250;
                        gotLegendary = true;

                        break;
                    }
                    if (createNew == false)
                    {

                        dicTrash.Add(inputZero, qntt);
                    }
                    createNew = false;
                    i++;

                }
                if (gotLegendary==true)
                {
                    break;
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            dicTrash = dicTrash.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            dicdic = dicdic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dicdic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in dicTrash)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
