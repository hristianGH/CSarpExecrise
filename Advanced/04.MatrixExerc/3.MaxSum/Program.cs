using System;
using System.Linq;

namespace _3.MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexX = 0,indexY=0, sum = 0, sumCheck = int.MinValue; 
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrixx = new int[n[0], n[1]];
            ToMatrix(n, matrixx);
            for (int i = 0; i < n[0]-2; i++)
            {
                for (int y = 0; y < n[1]-2; y++)
                {
                    sum = matrixx[i, y] + matrixx[i, y + 1] + matrixx[i, y + 2] + matrixx[i+1, y] + matrixx[i + 1, y+1]+ matrixx[i + 1, y + +2] + matrixx[i + 2, y]+ matrixx[i +2, y + 1] + matrixx[i +2, y + +2];
                    if (sum>sumCheck)
                    {
                        sumCheck = sum;
                        indexX = y;
                        indexY = i;
                    }
                }
            }
            Console.WriteLine($"Sum = {sumCheck}");
            for (int i = indexY; i < n[0]; i++)
            {
                for (int y = indexX; y < n[1]-1; y++)
                {
                    Console.Write(matrixx[i,y]+" " );
                }
                Console.WriteLine();
            }
            
           
        }
        
        static void ToMatrix(int[] n, int[,] matrixx)
        {
            for (int i = 0; i < n[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int y = 0; y < n[1]; y++)
                {
                    matrixx[i, y] = int.Parse(input[y]);
                }
            }

        }
    }
}
