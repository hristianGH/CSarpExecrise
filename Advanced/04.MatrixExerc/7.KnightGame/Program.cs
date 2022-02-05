using System;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int removed = 0;
            while (true)
            {
                var possibleAttacks = new int[n, n];

                for (var row = 0; row < n; row++)
                    for (var col = 0; col < n; col++)
                    {
                        if (board[row, col] == '0')
                        {
                            possibleAttacks[row, col] = 0;
                            continue;
                        }
                        int attacks = 0;
                        if (!IsEmpty(row + 1, col + 2, board)) attacks++;
                        if (!IsEmpty(row + 2, col + 1, board)) attacks++;
                        if (!IsEmpty(row - 1, col + 2, board)) attacks++;
                        if (!IsEmpty(row - 2, col + 1, board)) attacks++;
                        if (!IsEmpty(row + 2, col - 1, board)) attacks++;
                        if (!IsEmpty(row + 1, col - 2, board)) attacks++;
                        if (!IsEmpty(row - 1, col - 2, board)) attacks++;
                        if (!IsEmpty(row - 2, col - 1, board)) attacks++;
                        possibleAttacks[row, col] = attacks;
                    }

                int removeRow = -1;
                int removeCol = -1;
                for (var row = 0; row < n; row++)
                    for (var col = 0; col < n; col++)
                        if (possibleAttacks[row, col] > (removeRow >= 0 ? possibleAttacks[removeRow, removeCol] : 0))
                        {
                            removeRow = row;
                            removeCol = col;
                        }
                if (removeRow == -1)
                    break;
                removed++;
                board[removeRow, removeCol] = '0';
            }
            Console.WriteLine(removed);
        }

        private static bool IsEmpty(int x, int y, char[,] board)
        {
            return x < 0 || x >= board.GetLength(0) ||
                   y < 0 || y >= board.GetLength(1) ||
                   board[x, y] == '0';
        }
    }
}
