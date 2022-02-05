using System;

namespace _1.DiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumX = 0, sumY = 0 ;
            int n = int.Parse(Console.ReadLine());
            int[,] matrixx = new int[n,n];
            ToMatrix(n, matrixx);
            for (int i = 0; i < n; i++)
            {
                sumX += matrixx[i, i];
                sumY += matrixx[i, (n-1)-i];
            }
             
            Console.WriteLine(Math.Abs(sumX-sumY));
        }
       static int[,] ToMatrix(int n ,int[,] matrixx)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int y = 0; y < n; y++)
                {
                    matrixx[i, y] = int.Parse(input[y]);
                }
            }
            return matrixx;
        }

    }
}
 