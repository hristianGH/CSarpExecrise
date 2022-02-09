using System;

namespace _2.Sum
{
    class Program
    {
        public delegate int EachNumSum(int x, int y);
             
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
             
            EachNumSum xPlusY = (int x, int result) =>
            {
                result += x;
                return result;
            };
            

            Console.WriteLine($"{arr.Length}");
            Console.WriteLine(Sum(arr,xPlusY));
        }

        private static int Sum(string[] arr,EachNumSum xPlusY)
        {
            int result = 0;
            foreach (var item in arr)
            {
               result= xPlusY(int.Parse(item), result);
            }
            return result  ;
        }

    }
}
