using System;

namespace _7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Repeater(input, n);
        }
        public static string Repeater(string input,int n)
        {
            string pender = "";
            for (int i = 0; i <= n; i++)
            {
                pender += input;
            }
            return pender;
        }
    }
}
