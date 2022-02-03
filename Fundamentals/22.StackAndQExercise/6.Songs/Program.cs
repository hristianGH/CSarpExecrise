using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));
            string array = Console.ReadLine();
            while (queue.Count>0)
            {
                if (array.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (array.Contains("Add"))
                {
                    if (queue.Contains(array.Substring(4)))
                    {
                        Console.WriteLine($"{array.Substring(4)} is already contained!");
                    }
                    else
                    {
                    queue.Enqueue(array.Substring(4));

                    }

                }
               else if (array.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue.ToArray()));
                }
                array = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
