using System;

namespace _2.AddSir
{
    delegate void Each(string x);

    class Program
    {
        static void Main(string[] args)
        {
            Each each = x =>
            {

                foreach (var item in x.Split())
                {
                    Console.WriteLine($"Sir {item}" );
                }
            };
            each(Console.ReadLine());
        }
    }
}
