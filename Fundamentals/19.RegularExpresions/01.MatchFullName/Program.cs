using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b");
            var output = reg.Matches(input);
            Console.WriteLine(string.Join(' ',output));
             
        }
    }
}
