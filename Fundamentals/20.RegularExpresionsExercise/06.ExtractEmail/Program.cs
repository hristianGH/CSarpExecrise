using System;
using System.Text.RegularExpressions;
namespace _06.ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var email = Regex.Matches(input, @"([\d\w\.\-_]+\@[\w\-_\.]+\.[\w]+)([\.]\w+)?");

            foreach (var item in email)
            {
                Console.WriteLine(item);
            }
        }
    }
}
