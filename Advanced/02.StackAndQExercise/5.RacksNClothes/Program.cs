using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RacksNClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberQueue = 0, sum = 0, count = 1;
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int n = int.Parse(Console.ReadLine());
            while (queue.Count > 0)
            {
                    numberQueue = queue.Dequeue();
                if (numberQueue+sum>n)
                {
                    sum += numberQueue;

                    count++;
                    sum -=n ;
                    numberQueue = 0;
                }
                else
                {
                    sum += numberQueue;
                }
                
            }
            if (sum>0)
            {
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
