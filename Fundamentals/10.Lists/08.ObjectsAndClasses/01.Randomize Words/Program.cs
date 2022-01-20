using System;
using System.Linq;

namespace _01.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                Random roll = new Random();
                System.Threading.Thread.Sleep(10);
                string holder = input[i];
                int swap = roll.Next(0,input.Length);
                input[i] = input[swap];
                input[swap] = holder;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
