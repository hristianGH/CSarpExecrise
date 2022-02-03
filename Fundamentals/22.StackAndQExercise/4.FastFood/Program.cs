using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int[] array = queue.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                int order = array[i];
                if (n-order> 0)
                {
                    n -= order;
                    queue.Dequeue();
                }
                else if (n-order<0)
                {

                 
                    Console.WriteLine($"Orders left: {string.Join(" ",queue.ToArray())}");
                    break;
                }
                 
            }
            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
