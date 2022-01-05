using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool breaker = false;
            for (int numH = 0; numH <= n; numH++)
            {
                for (int numW = 0; numW <= numH; numW++)
                {
                    if (num > n)
                    {
                        breaker = true;
                        break;
                    }
                    Console.Write(num +" ");
                    num++;
                }
                if (breaker==true)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
