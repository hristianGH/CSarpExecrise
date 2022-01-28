using System;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = input.Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
            string[] numbersTopFive =new string [numbers.Length];
           
             
            bool allTheSame = true;
            Array.Sort(numbers);
            Array.Reverse(numbers);
            double sum = 0;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            sum = sum / numbers.Length;
             for (int i = 0; i < numbers.Length; i++)
             {
                 if (numbers[i] > sum)
                 {
                     numbersTopFive[counter] =numbers[i].ToString();
                     counter++;
                    allTheSame = false;
                 }
                 
                if (counter>4)
                {
                    break;
                }
            
             }
            if (allTheSame==true)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }
            Console.WriteLine(string.Join((" "), numbersTopFive));
        }
    }
}
