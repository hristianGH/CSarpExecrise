using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numberPocket = new int[n];
            for (int i = 0; i <n ; i++)
            {
                numberPocket[i] = int.Parse(Console.ReadLine());
            }
            for (int y = n; y >0 ; y--)
            {
                Console.Write ($"{numberPocket[y-1]} ");
            }
        }
    }
}
