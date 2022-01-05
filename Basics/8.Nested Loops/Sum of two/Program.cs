using System;

namespace Sum_of_two
{
    class Program
    {
        static void Main(string[] args)
        {

            int begNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstLoop = begNum; firstLoop <= endNum; firstLoop++)
            {
                for (int secondLoop = begNum; secondLoop <= endNum; secondLoop++ )
                {
                int sum = firstLoop + secondLoop;
                if (sum == n)
                {
                    break;
                    counter++;
                }
            }
        }
    }
}
