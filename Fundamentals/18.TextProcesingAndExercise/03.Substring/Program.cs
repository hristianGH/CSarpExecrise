using System;
using System.Linq;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
           int index =  input.IndexOf(word,StringComparison.OrdinalIgnoreCase);
            while (index!=-1)
            {
           input= input.Remove(index,word.Length);
                index = input.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine(input);
        }
    }
}
