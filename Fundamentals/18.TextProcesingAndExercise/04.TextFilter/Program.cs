using System;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string replace;
            foreach (var item in banned)
            {
                replace = new string('*', item.Length);
                text = text.Replace(item, replace);
            }
            Console.WriteLine(text);
        }
    }
}
