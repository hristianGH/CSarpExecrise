using System;
using System.Linq;

namespace _4.Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Isfound = false;
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int y = 0; y < n; y++)
                {
                    matrix[i, y] = arr[y];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[i,y]==symbol)
                    {
                        Console.WriteLine($"({i}, {y})");
                        Isfound = true;
                    }
                    
                }
                
            }
            if (Isfound==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
