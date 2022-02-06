using System;
using System.Collections.Generic;

namespace _7.Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            HashSet<string> normal = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "PARTY" && input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    normal.Add(input);
                }
                input = Console.ReadLine();
            }
            if (input == "PARTY")
            {
                input = Console.ReadLine();
                while (input != "END")
                {
                    if (normal.Contains(input))
                    {
                        normal.Remove(input);
                    }
                    if (vip.Contains(input))
                    {
                        vip.Remove(input);
                    }
                    input = Console.ReadLine();
                }
            }
            count = vip.Count + normal.Count;
            Console.WriteLine(count);
            if (vip.Count > 0)
            {
                foreach (var item in vip)
                {
                    Console.WriteLine(item);
                }
            }
            if (normal.Count > 0)
            {

                foreach (var item in normal)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
