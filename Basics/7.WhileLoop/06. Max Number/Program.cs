using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            int Min = int.MinValue;
            
            while (imput!="Stop")
            {
            int num = int.Parse(imput);
                if (num>Min)
                {
                    Min = num;

                }
                else
                {
                   
                }
                imput = Console.ReadLine();
            }
            Console.WriteLine(Min);
        }
    }
}
