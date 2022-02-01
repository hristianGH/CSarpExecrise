using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, @"\b([0-2]\d|[3][0-1])([\.\-\/])([A-Z][a-z]{2})\2([0-9]{4})\b");
            foreach (Match item in matches)
            {
                var day = item.Groups[1].Value;
                var month = item.Groups[3].Value;
                var year = item.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
