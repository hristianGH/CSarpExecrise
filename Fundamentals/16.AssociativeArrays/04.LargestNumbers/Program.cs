using System;
using System.Linq;

namespace _04.LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToArray();
            if (h.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(h[i]+" ");
                }
            }
            else
            {
                foreach (var item in h)
                {
                    Console.Write(item+" ");
                }
            }
        }
    }
}
