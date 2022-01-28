using System;

namespace SumNumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < imput.Length; i++)
            {
                int imputValue = (int)Char.GetNumericValue(imput[i]);
                sum = sum +imputValue;
            }
            Console.WriteLine(sum);
        }
    }
}
