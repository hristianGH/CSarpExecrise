using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            string[] imputArray = imput.Split(' ');

            for (int i = 0; i < imputArray.Length; i++)
            {
                double arrayToNum = double.Parse(imputArray[i]);
                Math.Round(arrayToNum);
                 
                Console.WriteLine($"{imputArray[i]} => {Math.Round(arrayToNum,MidpointRounding.AwayFromZero)} ");

                //Console.WriteLine($"{arrayToNum:f0}");


            }


        }
    }
}
