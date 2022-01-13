using System;
using System.Linq;

namespace _10.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string imputDigits = Console.ReadLine();
            char[] arrDigits = imputDigits.ToCharArray();
             int odd = 0;
             int even = 0;
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < arrDigits.Length; i++)
            {
                int stringToInteger = 0;
                string charConverter ="" ; // arrDigits[i].ToString();
                if (char.IsDigit(arrDigits[i]))
                {
                    charConverter = arrDigits[i].ToString();
                    stringToInteger = int.Parse(charConverter);
                }
                Checker(out odd, out even,  stringToInteger);
                oddSum += odd;
                evenSum += even;
            }
            Console.WriteLine(oddSum*evenSum);
        }

       private static void Checker(out int oddSum, out int evenSum,  int stringToInteger)
        {
            oddSum = 0;
            evenSum = 0;

            if (stringToInteger % 2 == 0)

            {
                 evenSum += stringToInteger;
            }
            else
            {
                 oddSum += stringToInteger;
            }
              
           // Console.WriteLine(oddSum + "" +evenSum);

        }
       
    }
}