using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _01.SumAjust
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            for (int i = 1; i < input.Count-1; i++)
            {
                if (i>0)
                {

                    if (input[i] == input[i - 1])
                    {
                        input[i] += input[i - 1];
                        input.RemoveAt(i - 1);
                        i = 0;
                    }
                    
                }
                
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
