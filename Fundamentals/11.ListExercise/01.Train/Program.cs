using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] input = comand.Split();
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    CheckCapacity(capacity, input,wagons);
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }


        private static void CheckCapacity(int capacity,string[] comand,List<int> wagons)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (capacity >= wagons[i] + int.Parse(comand[0]))
                {
                    wagons[i] += int.Parse(comand[0]);
                    break;
                }
            }
        }
    }
}
