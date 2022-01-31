using System;
using System.Linq;
using System.Text;

namespace _05.DigitLetterOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            input.Where(x => char.IsDigit(x)).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
            input.Where(x => char.IsLetter(x)).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
            input.Where(x => !char.IsLetterOrDigit(x)).ToList().ForEach(x => Console.Write(x));


        }
    }
}
