using System;
using System.Collections.Generic;

namespace _9.ListPredicates
{
    class Program
    {
        public delegate void Divisible(int n, string[] a);
        static void Main(string[] args)
        {
            Divisible div = (num, arr) =>
            {
                HashSet<int> set = new HashSet<int>();
                for (int i = 1; i <= num; i++)
                {
                    bool check = false;
                    foreach (var item in arr)
                    {
                        int itemNum = int.Parse(item);
                        if (i%itemNum==0)
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                        }
                    }
                    if (check==true)
                    {
                        set.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ",set));
            };
            int n = int.Parse(Console.ReadLine());
            div(n, Console.ReadLine().Split());
        }
    }
}
