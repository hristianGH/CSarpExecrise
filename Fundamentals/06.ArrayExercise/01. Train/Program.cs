using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrWagons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arrWagons[i] = int.Parse(Console.ReadLine());
                sum = arrWagons[i] + sum;
            }
            for (int i = 0; i < arrWagons.Length; i++)
            {
            Console.Write($"{arrWagons[i]} ");


            }
            Console.WriteLine(Environment.NewLine + sum);
        }
    }
}
