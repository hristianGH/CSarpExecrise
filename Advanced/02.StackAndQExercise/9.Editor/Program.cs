using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Dictionary<int,string> undo = new Dictionary<int, string>();
            Stack<char> letters = new Stack<char>();
            char[] somth= new char[letters.Count];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char number = input[0];
                input = input.Substring(1);
                string newinput = "";
                input.ToCharArray().Where(x => !char.IsWhiteSpace(x)).ToList().ForEach(x => newinput += x) ;
                switch (number)
                {
                    
                    case '1':
                        somth = letters.ToArray();
                        newinput.ToCharArray().ToList().ForEach(x => letters.Push(x));
                        //append
                       
                        break;
                    case '2':
                        somth = letters.ToArray();
                        for (int y = 0; y < int.Parse(newinput); y++)
                        {
                            letters.Pop();
                        }
                        //errase
                        break;
                    case '3':
                        char[] lettersArray = letters.ToArray();
                        Console.WriteLine(lettersArray[int.Parse(newinput)-1]);
                        //return
                        break;
                    case '4':
                        letters = new Stack<char>(somth);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
