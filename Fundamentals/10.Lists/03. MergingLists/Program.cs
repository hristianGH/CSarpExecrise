using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> inputTheTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> saveList = new List<int>();
            int counterOne = input.Count - 1;
            int counterTwo = inputTheTwo.Count - 1;
            int indexOne = 0;
            int indexTwo = 0;

            while (counterOne != 0 || counterTwo != 0)
            {
                if (counterOne > 0)
                {
                    saveList.Add(input[indexOne]);
                    indexOne++;
                    counterOne--;
                }
                if (counterTwo > 0)
                {
                    saveList.Add(inputTheTwo[indexTwo]);
                    indexTwo++;
                    counterTwo--;
                }
            }


            Console.WriteLine(string.Join(" ", saveList));
        }
    }
}
