using System;
using System.Collections.Generic;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> word = new Stack<char>(Console.ReadLine().ToCharArray());
            while (word.Count > 0)
            {
                Console.Write(word.Pop());
            }
        }
    }
}
