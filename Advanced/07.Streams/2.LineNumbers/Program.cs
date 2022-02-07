using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paths = new string[] { "data", "Textfile1.txt", "Textfile2.txt" };
            string pathRead = Path.Combine(paths[0], paths[1]);
            using (StreamReader reader = new StreamReader(pathRead))
            {
                string pathWrite = Path.Combine(paths[0], paths[2]);
                using (StreamWriter writer = new StreamWriter(pathWrite))
                {
                    int index = 1;
                    paths[0] = reader.ReadLine();
                    while (paths[0] != null)
                    {
                        writer.WriteLine($"{index}. {paths[0]}");
                        paths[0] = reader.ReadLine();
                        index++;
                    }
                }

            }

        }
    }
}
