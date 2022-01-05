using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string charec = Console.ReadLine();
            for (int i =0; i < charec.Length; i++)
            {
                char letter = charec[i];
                Console.WriteLine(letter);
            }
        }
    }
}
