using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] imputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool equalizer = false;
            for (int i = 0; i < imputNum.Length; i++)
            {
                int sumRight = 0;
                int sumLeft = 0;
                for (int y = i + 1; y < imputNum.Length; y++)
                {
                    sumRight += imputNum[y];
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += imputNum[j];
                }

               // Console.WriteLine(sumLeft + " " +  sumRight);
               // Console.WriteLine(imputNum[i]);
                if (sumLeft == sumRight )
                {
                Console.WriteLine(i);
                    equalizer = true;
                }
            }
            if (equalizer==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
