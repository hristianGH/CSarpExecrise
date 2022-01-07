using System;

namespace _05._Print_Part_Of_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begining; i <= end; i++)
            {
            char letter =(char) i;

                Console.Write(letter + " ");

            }
        }  
    }
}
