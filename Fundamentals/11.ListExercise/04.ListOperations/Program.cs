using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string comand = Console.ReadLine();

            while (comand != "End")

            {
                string[] input = comand.Split();
                switch (input[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        break;
                    case "Insert":
                        int number = int.Parse(input[1]);
                        int index = int.Parse(input[2]);
                       
                        if (IsValidIndex(index,numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }
                      
                        break;
                    case "Remove":
                        if (IsValidIndex(int.Parse(input[1]),numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(input[1]));
                        }
                       
                        break;
                    case "Shift":
                        int rotation =int.Parse( input[2]);
                        if (input[1]== "left")
                        {
                            for (int i = 0; i < rotation; i++)
                            {
                                int firstNumOfList = numbers[0];
                                for (int j = 0; j < numbers.Count - 1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                                numbers[numbers.Count - 1] = firstNumOfList;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rotation; i++)
                            {
                                int lastNumOfList = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = lastNumOfList;
                            }

                        }
                        
                        break;
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static bool IsValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
