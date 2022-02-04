using System;
using System.Linq;

namespace _6.JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[row.Length];
                for (int y = 0; y < row.Length; y++)
                {
                    matrix[i][y] = row[y];
                }
            }
            string[] word = Console.ReadLine().Split();
            while (word.Contains("END") == false)
            {
                int row = int.Parse(word[1]);
                int col = int.Parse(word[2]);
               
                if (row > matrix.GetLength(0)-1 ||row<0)
                {

                    Console.WriteLine("Invalid coordinates");
                }
                else if (col > matrix[row].Length || col<0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {

                    if (word.Contains("Add"))
                    {

                        matrix[row][col] += int.Parse(word[3]);
                    }
                    else
                    {
                        matrix[row][col] -= int.Parse(word[3]);
                    }
                }
                word = Console.ReadLine().Split();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                 
                    Console.WriteLine(string.Join(" ", matrix[i]));
                 
            }
        }
    }
}
