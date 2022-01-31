using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> names = new List<string>();
            names.AddRange(input);
            foreach (var item in names)
            {
                bool isTrue= item.All(c => Char.IsLetterOrDigit(c) || c == '_'||c=='-');
                if (isTrue==true&&item.Length>3&&item.Length<16)
                {
                    Console.WriteLine(item);
                }
            }
                

        }
    }
}
