using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _07.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ordinariList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] command = Console.ReadLine().ToUpper().Split();
            bool changesMade = false;
            while (command[0] != "END")
            {
                int commandNumber = 0;
                int commandIndex = 0;
                switch (command[0])
                {
                    case "ADD":
                        commandNumber = int.Parse(command[1]);
                        ordinariList.Add(commandNumber);
                        changesMade = true;
                        break;
                    case "REMOVE":
                        commandNumber = int.Parse(command[1]);
                        ordinariList.Remove(commandNumber);
                        changesMade = true;
                        break;
                    case "REMOVEAT":
                        commandNumber = int.Parse(command[1]);
                        ordinariList.RemoveAt(commandNumber);
                        changesMade = true;
                        break;
                    case "INSERT":
                        commandNumber = int.Parse(command[1]);
                          commandIndex = int.Parse(command[2]);
                        ordinariList.Insert(commandIndex, commandNumber);
                        changesMade = true;
                        break;
                    case "CONTAINS":
                        commandNumber = int.Parse(command[1]);
                        Console.WriteLine(ordinariList.Contains(commandNumber) ? "Yes" : "No such number");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(" ", ordinariList.Where(x => x % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(" ", ordinariList.Where(x => x % 2 != 0)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(string.Join(" ", ordinariList.Sum()));
                        break;
                    case "FILTER":
                        commandIndex = int.Parse(command[2]);
                        if (command[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", ordinariList.Where(x => x < commandIndex)));

                        }
                        else if (command[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", ordinariList.Where(x => x <= commandIndex)));

                        }
                        else if (command[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", ordinariList.Where(x => x > commandIndex)));

                        }
                        else if (command[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", ordinariList.Where(x => x >= commandIndex)));

                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().ToUpper().Split();

            }
            if (changesMade)
            {
                Console.WriteLine(string.Join(" ", ordinariList));
            }

        }
    }
}
