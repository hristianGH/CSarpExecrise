using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int imput = 0 ;
           
            InputToSum(imput);
        }

        private static void InputToSum(int imput  )
        {
            int[] imputArr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                imput = int.Parse(Console.ReadLine());
                imputArr[i] = imput;
            }
            imput = (imputArr[0] + imputArr[1]) - imputArr[2];
             Console.WriteLine(imput);
        }
    }
}
