using System;

namespace _3.Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int y = 0; y < n; y++)
                {
                    matrix[i, y] = int.Parse(input[y]); 
                }
            }
            n = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                n += matrix[i,i];
            }
            Console.WriteLine(n);
        }
    }
}
