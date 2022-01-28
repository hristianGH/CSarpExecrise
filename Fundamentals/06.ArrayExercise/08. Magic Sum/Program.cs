using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] imputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < imputArr.Length; i++)
            {
                for (int j = i+1; j < imputArr.Length; j++)
                {
                    if (imputArr[i]+imputArr[j]==magicSum)
                    {
                        Console.WriteLine(imputArr[i] + " "+ imputArr[j]);
                        break;
                    }
                }
            }
        }
    }
}
