using System;
using System.Linq;

namespace _2.Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[n[0], n[1]];
            ToMatrix(n, matrix);
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int y = 0; y < matrix.GetLength(1)-1; y++)
                {
                    string symbol = matrix[i, y];
                    if (symbol==matrix[i,y+1]&&symbol==matrix[i+1,y]&&symbol==matrix[i+1,y+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
             

        }
        static void ToMatrix(int[] n,string[,] matrix)
        {
            for (int i = 0; i < n[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int y = 0; y < n[1]; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
        }
    }
}
