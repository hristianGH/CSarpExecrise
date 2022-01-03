using System;
using System.Globalization;
using System.Security.Cryptography;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double bughet = Double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            //
            if (bughet <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        bughet = bughet * 0.30;
                        place = "Camp";
                        break;
                    case "winter":
                        bughet = bughet * 0.70;
                        place = "Hotel";
                        break;
                }
            }
            else if (bughet <= 1000 && bughet > 100)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        bughet = bughet * 0.40;
                        place = "Camp";
                        break;
                    case "winter":
                        bughet = bughet * 0.80;
                        place = "Hotel";
                        break;
                }

            }
            else if (bughet >= 1000)
                destination = "Europe";
            {
                bughet = bughet * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place}  - {bughet:f2} ");
           

        }
    }
}
