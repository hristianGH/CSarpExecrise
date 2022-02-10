using System;

namespace _3.CustumMin
{
    public delegate void MIN(string[] x);
    class Program
    {
        static void Main(string[] args)
        {
            MIN min = x =>
            {
                int maxvalue = int.MaxValue;
                int minvalue = 0;
                foreach (var item in x)
                {
                    if (int.Parse(item) < maxvalue)
                    {
                        maxvalue = int.Parse(item);
                        minvalue = maxvalue;
                    }
                }
                Console.WriteLine(minvalue); ;
            };
            min(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));
        }

    }
}
    