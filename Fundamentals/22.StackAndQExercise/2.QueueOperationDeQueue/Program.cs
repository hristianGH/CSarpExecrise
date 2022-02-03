using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.QueueOperationDeQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < int.Parse(array[1]); i++)
            {
                queue.Dequeue();
            }
            if (queue.ToList().Contains(int.Parse(array[2])))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count>0)
            {
                Console.WriteLine(queue.ToList().Min());
            }
            else if (queue.Count<=0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
