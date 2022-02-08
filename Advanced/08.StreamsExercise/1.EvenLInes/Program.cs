using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _1.EvenLInes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerOne = new StreamReader(Path.Combine("newfolder", "textfile1.txt")))
            {
                int index = 0;
                using (FileStream fileOut = new FileStream(Path.Combine("newfolder", "out.txt"), FileMode.OpenOrCreate))
                {

                    using (StreamWriter writer = new StreamWriter(fileOut))
                    {
                        Regex matcher = new Regex(@"[\-\.\,\!\?]");
                        string line = readerOne.ReadLine();
                        while (line != null)
                        {
                            if (index % 2 == 0)
                            {

                                line = matcher.Replace(line, "@");
                                string[] arr = line.Split(" ");
                                line = "";
                                for (int i = arr.Length-1; i >= 0; i--)
                                {
                                    line += arr[i]+" ";
                                }
                                
                                 Console.WriteLine(line);
                            }
                            index++;
                                line = readerOne.ReadLine();

                        }
                    }
                }
            }
        }
    }
}
