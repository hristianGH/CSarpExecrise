using System;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int dip = int.Parse(Console.ReadLine());
            for (int i = 1; i<=dip ; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
