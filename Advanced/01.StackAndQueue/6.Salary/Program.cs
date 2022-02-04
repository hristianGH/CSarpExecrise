using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string input = Console.ReadLine();
            while (input.ToLower()!="end")
            {
                if (input=="Paid")
                {
                    while (names.Count>0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
