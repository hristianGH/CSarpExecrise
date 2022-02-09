using System;

namespace _4.AddTax
{
    public delegate decimal AddVat(decimal x);
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            AddVat vatPlus20 = x =>
            {
                return x * 1.20M;
            };
            foreach (var item in arr)
            {
                Console.WriteLine($"{vatPlus20(decimal.Parse(item)):f2}");
            }
        }
    }
}
