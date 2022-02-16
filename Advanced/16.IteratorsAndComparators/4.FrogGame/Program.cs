using System;

namespace _4.FrogGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ");
            int index = 0;
            int[] numArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = int.Parse(arr[i]);
                if (i % 2 == 0)
                {
                    numArr[index] = curr;
                    index++;
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int curr = int.Parse(arr[i]);
                if (i%2!=0)
                {
                    numArr[index] = curr;
                    index++;
                }
            }
            Console.WriteLine(string.Join(", ",numArr));
        }
    }
}
