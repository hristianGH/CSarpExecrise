using System;

namespace _04.CaesarCip
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number;
            foreach (var item in text)
            {
                 number = item+3;
                Console.Write((char)number+3);
            }
        }
    }
}
