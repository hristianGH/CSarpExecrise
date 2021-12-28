using System;

namespace DepositCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount to deposit");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter term of deposit");
            byte depositLenght = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter bank interest");
            double interest = double.Parse(Console.ReadLine());
            interest = interest * 0.01 ;
            double interestSoFar = (double) depositAmount * interest;
            double interestMonth = interestSoFar / 12;
            double sum = (double)depositAmount + depositLenght * interestMonth;
            Console.WriteLine($"Sum: {sum:f2}");
        }
    }
}
//1.Изчисляваме натрупаната лихва: 200 * 0.057(5.7 %) = 11.40 лв.
//2.Изчисляваме лихвата за 1 месец: 11.40 лв. / 12 месеца = 0.95 лв.
//3.Общата сума е: 200 лв. + 3 * 0.95 лв. = 202.85 лв.
