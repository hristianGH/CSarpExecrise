using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new BoxOfT<object>();
            box.Add(6);
            box.Add(7);
            box.Add(6);
            box.Add(7);
            box.Add(6);
            box.Add(7);
            foreach (var item in box)
            {
                Console.WriteLine(item);
            }
        }
    }
}
