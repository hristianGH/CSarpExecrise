using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] match = Regex.Matches(input, @"\+359([\s\-])2\1\b[0-9]{3}\b\1\b[0-9]{4}\b")
                      .Cast<Match>()
                      .Select(x => x.Value.Trim())
                       .ToArray();
            Console.WriteLine(string.Join(", ",match));
              
        }
    }
}
