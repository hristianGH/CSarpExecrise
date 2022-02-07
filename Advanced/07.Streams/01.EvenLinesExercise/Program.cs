using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.EvenLinesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string line = string.Empty;

                int row = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (row % 2 == 0)
                    {
                        Regex pattern = new Regex("[-,.!?]");

                        line = pattern.Replace(line, "@");

                        var lineArray = line.Split().ToArray().Reverse();

                        Console.WriteLine(string.Join(" ", lineArray));
                    }

                    row++;
                }
            }
        }
    }
}
