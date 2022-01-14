using System;

namespace _01.Smallest_Number_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.MaxValue;
            int input = 0;
            SmallestNum(input, firstNum);
        }

        private static void SmallestNum(int input,int firstNum)
        {
            for (int i = 0; i < 3; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input < firstNum)
                {
                    firstNum = input;
                }
            }
            Console.WriteLine(firstNum);
        }
    }
}
