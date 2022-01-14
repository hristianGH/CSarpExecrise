using System;
using System.Diagnostics.CodeAnalysis;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaToo =0;
            double suma=0 ;
              
            double input = double.Parse(Console.ReadLine());
            double inputToo = double.Parse(Console.ReadLine());
            FactorialConversionOne(input, ref suma);
            FactorialConversionTwo(inputToo, ref sumaToo);
            suma = suma / sumaToo;
             Console.WriteLine($"{suma:f2}") ;
        }

        private static void FactorialConversionOne(double input, ref double suma)
        {
            suma = input;
            for (int i = Convert.ToInt32(input - 1); i > 0; i--)
            {
                suma = suma * i;
            }

        }
        private static void FactorialConversionTwo(double inputTwo, ref double sumaTwo)
        {
            sumaTwo = inputTwo;
            for (int i = Convert.ToInt32(inputTwo - 1); i > 0; i--)
            {
                sumaTwo = sumaTwo * i;
            }
        }
    }
}
