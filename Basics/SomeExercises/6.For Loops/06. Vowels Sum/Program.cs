using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string imput = Console.ReadLine();
            for (int i = 0; i < imput.Length; i++)
                //a e i o u
                // 1 2 3 4 5
            {
                char letter = imput[i];
                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;

                        case 'e':
                        sum += 2;
                        break;

                        case 'i':
                        sum += 3;
                        break;

                        case 'o':
                        sum += 4;
                        break;

                        case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
