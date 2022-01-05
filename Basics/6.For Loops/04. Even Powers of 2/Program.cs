using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(one);
                one = one *2*2;
            }
        }
    }
}
