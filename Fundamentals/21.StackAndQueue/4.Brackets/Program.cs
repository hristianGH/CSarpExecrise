using System;
using System.Collections.Generic;

namespace _4.Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    brackets.Push(i);
                }
                if (input[i]==')')
                {
                    int end =i-brackets.Peek();
                    Console.WriteLine(input.Substring(brackets.Pop(),end+1));
                }

            }

             
        }
    }
}
