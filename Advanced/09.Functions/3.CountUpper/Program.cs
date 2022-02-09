using System;

namespace _3.CountUpper
{
    class Program
    {
        public delegate void IsFirstCharUpper(string[] txt);
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            IsFirstCharUpper ck = (string[] x) =>
            {
                foreach (var item in input)
                {
                    if (char.IsUpper(item[0]))
                    {
                        Console.WriteLine(item);
                    }
                }
            };
            ck(input);
              
             
        }
    }
}
