using System;
using System.Linq;

namespace _5.SquereSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 0, two = 0, sum = 0, oneY = 0, twoY = 0 ;
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            for (int i = 0; i < n[0]; i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int y = 0; y < n[1]; y++)
                {
                    matrix[i, y] = row[y];
                }
            }
            //
            for (int i = 0; i < n[0]-1; i++)
            {
                int comperable = int.MinValue;

                for (int y = 0; y < n[1]-1; y++)
                {
                    sum = matrix[i, y] + matrix[i, y + 1] + matrix[i + 1, y] + matrix[i + 1, y + 1];
                    if (sum>comperable)
                    {
                        comperable = sum;
                        one =i;
                        oneY = y;
                        two = comperable;
                    }
                }
            }
            Console.WriteLine($"{matrix[one,oneY]} {matrix[one, oneY+1]}");
            Console.WriteLine($"{matrix[one+1, oneY]} {matrix[one+1, oneY+1]}");
            Console.WriteLine(two);
        }
    }
}
