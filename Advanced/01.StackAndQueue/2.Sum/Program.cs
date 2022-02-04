using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumNum = 0;
            Stack<int> sum = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string[] input = Console.ReadLine().Split();
            while (input.Contains("end")!=true)
            {
                if (input.Contains("add", StringComparer.OrdinalIgnoreCase))
                {
                    sum.Push(int.Parse(input[1]));
                    sum.Push(int.Parse(input[2]));

                }
                else if (input.Contains("remove", StringComparer.OrdinalIgnoreCase) && (int.Parse(input[1]) < sum.Count()))
                {
                    for (int i = 1; i <= int.Parse(input[1]); i++)
                    {
                        sum.Pop();
                    }
                }
                input = Console.ReadLine().Split();
            }
            while (sum.Count>0)
            {
                sumNum += sum.Pop();
            }
            Console.WriteLine("Sum: "+sumNum);
        }
    }
}
