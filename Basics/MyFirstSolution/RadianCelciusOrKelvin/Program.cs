using System;

namespace RadianCelciusOrKelvin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char key = 'c';
            char keyTwo = 'c';
            double value = 0;
            double valueOriginal = 0;
            string choice = "";
            Console.WriteLine($"Press c for Celsius{Environment.NewLine}" +
                $"Press f for Fahrenheit{Environment.NewLine}" +
                $"Press k for Kelvin");
            key = Console.ReadKey().KeyChar;
            if (key!='c'||key!='f'||key!='k')
            {
                Console.WriteLine("key set to defaut Celsius because of bad input");
                key = 'c';
            }
            Console.WriteLine();
            Console.WriteLine("Enter Degree");
            valueOriginal = double.Parse(Console.ReadLine());
            if (key == 'c')
            {
                value = CelsiusToK(valueOriginal);
                choice = "Celsius";
            }
            else if (key == 'f')
            {
                value = FarenhaitToK(valueOriginal);
                choice = "Farenhait";
            }
            else if (key == 'k')
            {
                value = valueOriginal;
                choice = "Kelvin";
            }

            Console.WriteLine($"Convert {valueOriginal} {choice} To?");
            Console.WriteLine($"Press c for Celsius{Environment.NewLine}" +
                $"Press f for Fahrenheit{Environment.NewLine}" +
                $"Press k for Kelvin");

            keyTwo = Console.ReadKey().KeyChar;
            if (keyTwo != 'c' || keyTwo != 'f' || keyTwo != 'k')
            {
                Console.WriteLine("key set to defaut Celsius because of bad input");
                keyTwo = 'c';
            }
            value = KelvinToOther(value, keyTwo);
            Console.WriteLine();
            Console.WriteLine($"{valueOriginal:f2}{key} To {value:f2}{keyTwo}");
        }
        static double CelsiusToK(double value)
        {

            value = value + 273.15;  //converting to Kelvin will convert in else in the end
            return value;
        }
        static double FarenhaitToK(double value)
        {

            value = (value + 459.67) * 5 / 9; //converting to Kelvin will convert in else in the end
            return value;
        }

        static double KelvinToOther(double value, char keyTwo)
        {
            if (keyTwo == 'f')
            {
                value = value * 9 / 5 - 459.67;
            }
            else if (keyTwo == 'c')
            {
                value = value - 273.15;
            }
            return value;
        }
    }
}
