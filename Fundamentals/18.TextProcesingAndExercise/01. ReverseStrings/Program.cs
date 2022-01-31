using System;
using System.Linq;

namespace _01._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            while (input != "end")
            {
                string output = "";
                input.ToCharArray().Reverse().Where(x => x != null).ToList().ForEach(x => output += x);
                Console.WriteLine($"{input} = {output}");
                output = "";
                input = Console.ReadLine();
            }
        }
    }
}
