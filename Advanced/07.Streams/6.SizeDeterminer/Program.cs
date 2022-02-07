using System;
using System.IO;

namespace _6.SizeDeterminer
{
    class Program
    {
        static void Main(string[] args)
        {
                int index = 0;
                string[] path = Path.GetFullPath(Environment.CurrentDirectory).Split(Path.DirectorySeparatorChar);
            {
              
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == "repos")
                    {
                        index = i;
                    }
                }
            }
            string pathing = "";
            for (int i = 0; i < index; i++)
            {
              pathing=  Path.Combine(pathing,path[i]);
            }
            FileInfo lenght = new FileInfo(pathing);
            
            Console.WriteLine(lenght.);
        }
    }
}
