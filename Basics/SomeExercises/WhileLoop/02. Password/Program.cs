using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num>sum)
            {
                int numTwo = int.Parse(Console.ReadLine());
                sum += numTwo;
            }
            //if (sum>num)
            
                Console.WriteLine(sum);
            }
          //  else
          //  {
          //      Console.WriteLine(sum);
          //  }
        }

    }

