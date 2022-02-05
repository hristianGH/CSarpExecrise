using System;
using System.Linq;

namespace _5.MatrixSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] input = Console.ReadLine().ToCharArray();
            char[,] matrix = new char[n[0], n[1]];
            for (int i = 0; i < n[0]; i++)
            {

                for (int y = 0; y < n[1]; y++)
                {
                    if (index > input.Length - 1)
                    {
                        index = 0;
                    }
                    matrix[i, y] = input[index];
                    index++;
                }
                i++;
                index -= 2;
                if (i < n[0])
                {

                    for (int y = 0; y < n[1]; y++)
                    {
                        if (index < 0)
                        {
                            index = input.Length - 1;
                        }
                        matrix[i, y] = input[index];

                        index--;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write(matrix[i,y]);
                }
                Console.WriteLine();
            }
        }
    }
}
