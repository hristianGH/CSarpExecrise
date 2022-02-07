using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6.WarDrobee
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            string[] groped = Regex.Matches(input, @"([A-Za-z-])+[^ -> ]").Select(x => x.Value).ToArray();
            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(groped[0]))
                {
                    for (int y = 1; y < groped.Length; y++)
                    {
                        if (dic[groped[0]].ContainsKey(groped[y]))
                        {
                            dic[groped[0]][groped[y]]++;
                        }
                        else
                        {
                            dic[groped[0]].Add(groped[y], 1);

                        }

                    }
                }
                else
                {
                    dic.Add(groped[0], new Dictionary<string, int>());
                    for (int y = 1; y < groped.Length; y++)
                    {
                        if (dic[groped[0]].ContainsKey(groped[y]))
                        {
                            dic[groped[0]][groped[y]]++;
                        }
                        else
                        {
                            dic[groped[0]].Add(groped[y], 1);

                        }

                    }
                }
                input = Console.ReadLine();
                groped = Regex.Matches(input, @"([A-Za-z-])+[^ -> ]").Select(x => x.Value).ToArray();
            }
            
            foreach (var item in dic)
            {
                
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var itemTwo in item.Value)
                {
                    if (groped[0]==item.Key&&groped[1]==itemTwo.Key)
                    {
                        Console.WriteLine($"* {itemTwo.Key} - {itemTwo.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemTwo.Key} - {itemTwo.Value}");
                    }
                     
                }
            }
        }
    }
}
