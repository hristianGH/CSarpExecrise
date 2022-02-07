using System;
using System.Collections.Generic;

namespace _2.SetElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nOne = Console.ReadLine().Split();
             
            HashSet<int> setOne = new HashSet<int>(int.Parse(nOne[0]));
            for (int i = 0; i < int.Parse(nOne[0]); i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }
            
            HashSet<int> setTwo = new HashSet<int>(int.Parse(nOne[1]));
            for (int i = 0; i < int.Parse(nOne[1]); i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }
            if (setOne.Count>=setTwo.Count)
            {
                foreach (var item in setOne)
                {
                    if (setTwo.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            else
            {
                foreach (var item in setTwo)
                {
                    if (setTwo.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
