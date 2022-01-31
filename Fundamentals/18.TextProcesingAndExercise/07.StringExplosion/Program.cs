using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    bomb += (int)char.GetNumericValue(input[i + 1]);
                }
                if (bomb>0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    bomb--;
                }
              
            }
            Console.WriteLine(input);


        }
    }
}
