using System;
using System.Collections.Generic;

namespace _1.BoxOfGeneric
{
    public delegate void PrintAll(Box<int> numbers, Box<string> text);
    class Program
    {
        static void Main(string[] args)
        {
            PrintAll print = (x, y) =>
            {
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in y)
                {
                    Console.WriteLine(item);
                }
            };

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int value;
            bool IsItINT = int.TryParse(input, out value);
            if (IsItINT == true)
            {

                Box<int> boxInt = new Box<int>(n);
                boxInt.Value[0] = int.Parse(input);
                for (int i = 1; i < n; i++)
                {
                    boxInt.Value[i] = int.Parse(Console.ReadLine());
                }
                foreach (var item in boxInt)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Box<string> boxText = new Box<string>(n);
                boxText.Value[0] = input;
                for (int i = 1; i < n; i++)
                {
                    boxText.Value[i] = Console.ReadLine();
                }
                foreach (var item in boxText)
                {
                    Console.WriteLine($"{item}");
                }
            }
             
        }
    }
}
