using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            int[] numbers = imput.Split().Select(int.Parse).ToArray();
            //string collector = "";
            bool isBigger = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                 
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (numbers[y]>=current)
                    {
                        isBigger = false;
                        break;
                    }
                    if (isBigger)
                    {
                        Console.Write(current + " " );
                    }
                    isBigger = true;
                }   
            }
          // string[] collectorSplit = collector.Split().Distinct().ToArray();
          // 
          // Console.WriteLine($"{string.Join(" ",collectorSplit)}");
        }
    }
}
