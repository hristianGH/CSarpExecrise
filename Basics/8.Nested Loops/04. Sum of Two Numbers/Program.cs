using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int firstLoop = begNum; firstLoop <= endNum; firstLoop++)
            {
                for (int secondLoop = begNum; secondLoop <= endNum; secondLoop++ )
                {
                int sum = firstLoop + secondLoop;
                if (sum == n)
                {
                        Console.WriteLine($"Combination N:{counter} ({firstLoop} + {secondLoop} = {n})");
                        Environment.Exit(0);
                }
                    else
                    {
                        counter++;
                    }
              }

            }
            counter--;
                Console.WriteLine($"{counter} combinations - neither equals {n}"); 
        }
    }
}
 
         

           
 
