using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine()
                                         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine().ToLower()) != "3:1")
            {
                string[] arg = input.Split();
                string command = arg[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(arg[1]);
                    int endIndex = int.Parse(arg[2]);

                    startIndex = ValidateIndex(startIndex, listOfStrings);
                    endIndex = ValidateIndex(endIndex, listOfStrings);
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        listOfStrings[startIndex] += listOfStrings[startIndex + 1];
                        listOfStrings.RemoveAt(startIndex + 1);
                    }
                }

                if (command == "divide")
                {
                    int index = int.Parse(arg[1]);
                    int partitions = int.Parse(arg[2]);

                    string currentString = listOfStrings[index];
                    int partSize = currentString.Length / partitions;
                    bool isLenghtEnoughForEqualParts = currentString.Length % 2 == 0;

                    List<string> temp = new List<string>();
                    listOfStrings.RemoveAt(index);

                    for (int i = 0; i < partitions; i++)
                    {
                        string result = String.Empty;

                        for (int j = 0; j < partSize; j++)
                        {
                            result += currentString[(i * partSize) + j];
                        }

                        if (i == partitions - 1 && !isLenghtEnoughForEqualParts)
                        {
                            result += currentString.Substring(currentString.Length - 1);
                        }

                        temp.Add(result);
                    }

                    listOfStrings.InsertRange(index,temp);
                }
            }
            Console.WriteLine(string.Join(" ", listOfStrings));
        }

        private static int ValidateIndex(int index, List<string> listOfStrings)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > listOfStrings.Count - 1)
            {
                index = listOfStrings.Count - 1;
            }

            return index;
        }
    }
}
