using System;
using System.Linq;

namespace _01.SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] numbersMatrix = new int[n[0],n[1]];
            for (int i = 0; i < numbersMatrix.GetLength(0); i++)
            {
                string[] readConsole = Console.ReadLine().Split(", ");
                for (int y = 0; y < numbersMatrix.GetLength(1); y++)
                {
                    numbersMatrix[i, y] = int.Parse(readConsole[y]);
                }
            }
            int sum = 0;
            foreach (int item in numbersMatrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
