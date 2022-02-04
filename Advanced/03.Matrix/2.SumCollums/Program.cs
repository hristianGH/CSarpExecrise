using System;
using System.Linq;

namespace _2.SumCollums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] arrayRange = new int[range[0], range[1]];
            for (int i = 0; i < range[0]; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int y = 0; y < range[1]; y++)
                {
                    arrayRange[i, y] = int.Parse(numbers[y]);
                }
            }
            for (int i = 0; i < range[1]; i++)
            {
                int sum = 0;
                for (int y = 0; y < range[0]; y++)
                {
                    sum += arrayRange[y, i];
                }
                    Console.WriteLine(sum);
            }
        }
    }
}
