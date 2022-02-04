using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.StackOperationPop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]),
                s = int.Parse(input[1]),
                x = int.Parse(input[2]);
            Stack<int> stacked = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            if (stacked.Count>s)
            {
                for (int i = 0; i < s; i++)
                {
                    stacked.Pop();
                }
            }
            List<int> list = new List<int>(stacked.ToList());
            if (list.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                
                Console.WriteLine(list.Min());
            }
            
            
        }
    }
}
