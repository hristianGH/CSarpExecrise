using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string imputFirst = Console.ReadLine();
            string[] arrayFirst = imputFirst.Split(); 
            string imputSecond = Console.ReadLine();
            string[] arraySecond = imputSecond.Split();
            for (int i = 0; i < arraySecond.Length; i++)
            {
                for (int y = 0; y < arrayFirst.Length; y++)
                {

                    if (arraySecond[i]==arrayFirst[y])
                    {
                        Console.Write($"{arraySecond[i]} ");
                    }

                }
            }

        }
    }
}
