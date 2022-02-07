using System;
using System.Collections.Generic;
using System.IO;

namespace _3.Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dicdic = new Dictionary<string, int>();
            using (StreamReader toFind = new StreamReader(Path.Combine("data", "textfile1.txt")))
            {
                string[] words = toFind.ReadLine().Split();
                foreach (var item in words)
                {
                    dicdic.Add(item, 1);
                }
            }
            using (StreamReader toFind = new StreamReader(Path.Combine("data", "textfile2.txt")))
            {
                string reader = toFind.ReadLine();
                    string[] words = reader.Split();
                while (reader!=null)
                {
                    foreach (var itemTwo in words)
                    {
                        if (dicdic.ContainsKey(itemTwo.ToLower()))
                        {
                            dicdic[itemTwo.ToLower()]++;
                        }
                    }
                      reader = toFind.ReadLine();
                    if (reader!=null)
                    {
                      words = reader.Split();
                    }
                }
            }
            using (FileStream file = new FileStream(Path.Combine("data","textfileOut.txt"),FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    foreach (var item in dicdic)
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");  
                    }
                }
            }
        }
    }
}
