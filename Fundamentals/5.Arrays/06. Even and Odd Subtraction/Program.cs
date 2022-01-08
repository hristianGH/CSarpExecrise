using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            string[] collage = imput.Split(' ');
            int evenNum = 0;
            int oddNum = 0;
            for (int i = 0; i < collage.Length; i++)
            {
                int converter = int.Parse(collage[i]);
                if (converter % 2 == 0)
                {
                    evenNum = evenNum + converter;
                }
                else
                {
                    oddNum = oddNum + converter;
                }

            }
            evenNum = evenNum - oddNum;
            Console.WriteLine(evenNum);
        }
    }
}
