using System;

namespace _8.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fN = double.Parse(Console.ReadLine());
            double sN = double.Parse(Console.ReadLine());
            Power(fN, sN);

        }
        public static double Power(double fN,double sN)
        {
            return Math.Pow(fN,sN);
        }
    }
}
