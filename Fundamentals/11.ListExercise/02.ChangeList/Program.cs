using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] input = comand.Split();
                if (input[0] == "Delete")
                {
                    int number = int.Parse(input[1]);
                    list.RemoveAll(x => x == number);
                }
                else
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list)); 
        }
    }
}
