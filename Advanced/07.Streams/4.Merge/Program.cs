using System;
using System.IO;

namespace _4.Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Path.Combine("newFolder", "textfile1.txt")))
            {
                using (StreamReader srTwo = new StreamReader(Path.Combine("newFolder", "textfile2.txt")))
                {
                    using (FileStream outputFile = new FileStream(Path.Combine("newFolder", "OutPut.txt"), FileMode.OpenOrCreate))
                    {

                        using (StreamWriter writer = new StreamWriter(outputFile))
                        {

                            string textOne = sr.ReadLine();
                            string textTwo = srTwo.ReadLine();
                            while (textOne != null && textTwo != null)
                            {
                                writer.WriteLine(textOne);
                                writer.WriteLine(textTwo);
                                textOne = sr.ReadLine();
                                textTwo = srTwo.ReadLine();

                            }

                        }
                    }
                }
            }

        }
    }
}
