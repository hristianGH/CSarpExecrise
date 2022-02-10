using System;

namespace _7.LenghtChecker
{
    class Program
    {
        public delegate void LenghtCheck(string[] na,int n);
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LenghtCheck lenght = (name, n) =>
            {
                Array.ForEach(name, x =>
                 {
                     if (x.Length <= n)
                     {
                         Console.WriteLine(x);
                     }
                 });
            };
            lenght(Console.ReadLine().Split(),n);
        }
    }
}
