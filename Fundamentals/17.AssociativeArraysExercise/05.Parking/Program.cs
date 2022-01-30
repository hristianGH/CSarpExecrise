using System;
using System.Collections.Generic;

namespace _05.Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicdic = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                 
                switch (command[0])
                {

                    case "register":
                        if (dicdic.ContainsKey(command[1]) == true || dicdic.ContainsValue(command[2]) == true)
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {command[2]}");

                        }
                        else
                        {
                            dicdic.Add(command[1], command[2]);
                            Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (dicdic.ContainsKey(command[1])==false)
                        {
                            Console.WriteLine($"ERROR: user {command[1]} not found");
                        }
                        else
                        {
                            dicdic.Remove(command[1]);
                            Console.WriteLine($"{command[1]} unregistered successfully");
                        }
                        break;
                }

            }
            foreach (var item in dicdic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

