using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaxMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> queue = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();
                switch (array[0])
                {
                    
                    case "1":
                        if (array[1]!=null)
                        {
                            queue.Push(int.Parse(array[1]));
                        }
                        break;
                    case "2":
                        if (queue.Count>0)
                        {
                            queue.Pop();
                        }
                        break;
                    case "3":
                        Console.WriteLine(queue.ToList().Max());
                        break;
                    default:
                        Console.WriteLine(queue.Min());
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",queue.ToArray()));
        }
    }
}
