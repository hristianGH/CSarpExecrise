using System;

namespace _9._1_Left_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int outA = 0;
            int outB = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                outA +=  a;
            }
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                outB += b;

            }
            int diff = (outA - outB)*-1;
            int diffPositive = outA - outB;
            if (outA==outB)
            {
                Console.WriteLine($"Yes, sum = {outA}");
            }
            else if (outA!=outB)
            {
                if (outA-outB <0)
                {
                  Console.WriteLine($"No, diff = {diff}");

                }
                else
                {
                  Console.WriteLine($"No, diff = {diffPositive}");

                }
            }

          //Console.WriteLine(outA);
          // Console.WriteLine(outB);
        }  
    }
}
