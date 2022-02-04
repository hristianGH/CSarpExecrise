using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            int bomb = 0;
            while (names.Count>1)
            {
                bomb++;
                if (bomb==n)
                {
                    Console.WriteLine($"Removed {names.Dequeue()}");
                     bomb = 0;
                }
                else
                {
                  names.Enqueue(names.Dequeue());

                }
                
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
