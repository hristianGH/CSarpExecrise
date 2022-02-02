using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.EvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> even = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(x=>x%2==0));
            Console.WriteLine(string.Join(", ",even));
        }
    }
}
