using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            double sum = 0;
            while (imput!="NoMoreMoney")
            {
                double moneyImput = double.Parse(imput);
                if (moneyImput<0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:F2}");
                    Environment.Exit(0);
                }
                else
                {
                 Console.WriteLine($"Increase: {moneyImput}");
                    sum += moneyImput;
                }
                  imput = Console.ReadLine();

                  
            }
            
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
