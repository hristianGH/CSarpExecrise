using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Calculator
{
    class Program
    {
        static void Main(string[] args) {
            {
                int sumNum = 0;
                Stack<string> sum = new Stack<string>(Console.ReadLine().Split().Reverse());
                sumNum = int.Parse(sum.Pop());
                while (sum.Count>1)
                {
                    if (sum.Pop()=="+")
                    {
                        sumNum += int.Parse(sum.Pop());
                    }
                    else
                    {
                        
                        sumNum -= int.Parse(sum.Pop());

                    }
                }
                Console.WriteLine(sumNum);
                 
            }

        }
    }
}

