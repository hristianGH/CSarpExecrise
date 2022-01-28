using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            int[] kamikadze = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            int bombNum = kamikadze[0];
            int power = kamikadze[1];
            int bombNumRemoved = 1;

            int bombKamikadze = list.IndexOf(bombNum);
            
            while (bombKamikadze != -1)
            {
                int leftNums = bombKamikadze - power;
                int rightNums = bombKamikadze + power;
                if (leftNums < 0)
                {
                    leftNums = 0;
                }
                if (rightNums  > list.Count-1)
                {
                    rightNums = list.Count - 1;
                }

                list.RemoveRange(leftNums, rightNums - leftNums + bombNumRemoved);

                bombKamikadze = list.IndexOf(bombNum);
            }
            int sum = list.Sum(); 
            Console.WriteLine(sum);
        }
    }
}
