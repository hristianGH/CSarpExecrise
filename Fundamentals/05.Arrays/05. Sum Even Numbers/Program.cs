using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            string[] collage = imput.Split(' ');
            int evenNum = 0;
            for (int i = 0; i < collage.Length; i++)
            {
                int converter = int.Parse(collage[i]);
                if (converter%2==0)
                {
                    evenNum = evenNum + converter;
                }
                else 
                {

                }
                 
            }
            Console.WriteLine(evenNum);
        }
    }
}
