using System;

namespace _6.RemoveDivided
{
    class Program
    {
        public delegate void DivisionIsDeath(string[] ar, int n);
        static void Main(string[] args)
        {
            DivisionIsDeath div = (ar, n) =>
            {
                int index = 0;
                foreach (var item in ar)
                {
                    int number = int.Parse(item);
                    if (number % n != 0)
                    {
                        index++;
                    }
                }
                int[] result = new int[index];
                
                foreach (var item in ar)
                {
                    int number = int.Parse(item);
                    if (number % n != 0)
                    {
                        result[index-1] = number;
                        index--;

                    }
                }
                Console.WriteLine(string.Join(" ", result));

            };
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            div(input, n);
        }
    }
}
