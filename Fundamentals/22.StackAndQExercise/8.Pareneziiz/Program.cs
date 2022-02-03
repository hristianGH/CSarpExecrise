using System;
using System.Collections.Generic;

namespace _8.Pareneziiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>(Console.ReadLine().ToCharArray());
            //bool isYez = true;
            for (int i = 0; i < list.Count/2; i++)
            {
                int one = list[i];
                int two = list[list.Count - 1 - i] - 2;
                if (one!=two&&one-1!=two)
                {
                    
                    Console.WriteLine("NO");
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("YES");
        }
    }
}
