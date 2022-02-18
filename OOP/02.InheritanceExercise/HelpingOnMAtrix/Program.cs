using System;
using System.Linq;

namespace HelpingOnMAtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] garden = new int[rows, cols];

            FillMatrix(rows, cols, garden);

            string input;

            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] cordinates = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int x = cordinates[0];//row
                int y = cordinates[1];//col

                if (ValidateCordinates(rows, cols, x, y))
                {
                    LeftColumn(garden, x, y);
                    RightColumn(cols, garden, x, y);
                    UpRow(garden, x, y);
                    DownRow(rows, garden, x, y);

                }
                if (!ValidateCordinates(rows, cols, x, y))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            PrintMatrix(rows, cols, garden);

        }

        private static void PrintMatrix(int rows, int cols, int[,] garden)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void DownRow(int rows, int[,] garden, int x, int y)
        {
            int down = x + 1;
            while (down <= rows - 1)
            {
                if (garden[down, y] == 1)
                {
                    garden[down, y]++;
                }
                else
                {
                    garden[down, y] = 1;
                }
                down++;
            }
        }

        private static void UpRow(int[,] garden, int x, int y)
        {
            int up = x - 1;

            while (up >= 0)
            {
                if (garden[up, y] == 1)
                {
                    garden[up, y]++;
                }
                else
                {
                    garden[up, y] = 1;
                }
                up--;
            }

        }

        private static void RightColumn(int cols, int[,] garden, int x, int y)
        {
            int right = y + 1;
            while (right <= cols - 1)
            {
                if (garden[x, right] == 1)
                {
                    garden[x, right] += 1;
                }
                else
                {
                    garden[x, right] = 1;
                    right++;
                }

            }
        }

        private static void LeftColumn(int[,] garden, int x, int y)
        {
            int left = y;
            while (left >= 0)
            {
                if (garden[x, left] == 1)
                {
                    garden[x, left] += 1;
                }
                else
                {
                    garden[x, left] = 1;
                    if (left > 0)
                    {
                        left--;
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        private static bool ValidateCordinates(int rows, int cols, int x, int y)
        {
            if (x < 0 || x > rows)
            {
                return false;
            }
            if (y < 0 || y > cols)
            {
                return false;
            }
            return true;
        }

        private static void FillMatrix(int rows, int cols, int[,] garden)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    garden[row, col] = 0;
                }
            }
        }
    }
}
