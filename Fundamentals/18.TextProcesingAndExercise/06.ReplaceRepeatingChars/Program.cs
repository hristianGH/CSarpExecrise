using System;
using System.Linq;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i]!=letters[i-1])
                {
                    sb.Append(letters[i - 1]);
                }
                 
            }
            sb.Append(letters[letters.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
