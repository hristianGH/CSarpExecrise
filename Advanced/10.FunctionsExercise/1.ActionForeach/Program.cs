using System;

namespace _1.ActionForeach
{
    class Program
    {
            delegate void Each(string x);
        
        static void Main(string[] args)
        {
            Each each = x =>
            {
               
                foreach (var item in x.Split())
                {
                      Console.WriteLine(item);
                }
            };
            each(Console.ReadLine());
        }
    }
}
