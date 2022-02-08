using System;
using System.IO;
using System.Text.RegularExpressions;



namespace _2.LinesAndMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerOne = new StreamReader(Path.Combine("newfolder", "textfile1.txt")))
            {
                int index = 1;
                int indexPunc = 0;
                int lettercounter = 0;
                using (FileStream fileOut = new FileStream(Path.Combine("newfolder", "out.txt"), FileMode.OpenOrCreate))
                {

                    using (StreamWriter writer = new StreamWriter(fileOut))
                    {
                        // Regex matcher = new Regex(@"[\-\.\,\!\?]");
                        string line = readerOne.ReadLine();
                        while (line != null)
                        {

                            foreach (var item in line)
                            {
                                if (char.IsPunctuation(item))
                                {
                                    indexPunc++;
                                }
                                if (char.IsLetter(item))
                                {
                                    lettercounter++;
                                }
                            }
                            Console.WriteLine($"{index}: {line} lenght: {lettercounter} punc: {indexPunc}");
                            line = readerOne.ReadLine();
                            indexPunc = 0;
                            lettercounter = 0;
                            index++;
                        }
                    }
                }
            }
        }
    }
}
