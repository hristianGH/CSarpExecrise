using System;
using System.IO;

namespace _5.Sliced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] folders = new string[4]
            {
                "output1.txt","output2.txt","output3.txt","output4.txt"
            };
                int index = 0;
            using (StreamReader reader = new StreamReader(Path.Combine("NewFolder", "textfile1.txt")))
            {
                while (reader.ReadLine() != null)
                {
                    index++;
                }
            }
            using (StreamReader reader = new StreamReader(Path.Combine("NewFolder", "textfile1.txt")))
            {
                string holder = "";


                for (int i = 0; i < 4; i++)
                {
                    using (FileStream outputfolder = new FileStream(Path.Combine("newfolder", folders[i]), FileMode.OpenOrCreate))
                    {
                        using (StreamWriter writer = new StreamWriter(outputfolder))
                        {

                            for (int y = 0; y < index / 4; y++)
                            {
                                holder = reader.ReadLine();
                                writer.WriteLine(holder);
                            }
                        }
                    }
                }

            }
        }
    }
}
