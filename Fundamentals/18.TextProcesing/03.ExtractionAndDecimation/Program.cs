using System;

namespace _03.ExtractionAndDecimation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine().Split("\\");
            string name = directory[directory.Length - 1].Split('.')[0];
            string extencion = directory[directory.Length - 1].Split('.')[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extencion}");

        }
    }
}
