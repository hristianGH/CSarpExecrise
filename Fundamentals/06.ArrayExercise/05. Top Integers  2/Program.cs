using System;
using System.Linq;

namespace _05._Top_Integers__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                for (int y = i + 1; y < numbers.Length; y++)
                {
                    if (numbers[y] >= current)
                    {
                        isBigger = false;
                        break;
                    }
                }
                    if (isBigger)
                    {
                        Console.Write(current + " ");
                    }
                    isBigger = true;
                
            }
        }
    }
}
