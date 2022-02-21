using System;

namespace _3.Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool invalidURL = false;
            IPhone phone = new StationaryPhone();
            Smartphone sPhone = new Smartphone();

            string[] input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                if (item.Length! < 10)
                {
                    sPhone.Call(item);
                }
                else
                {
                    phone.Call(item);
                }
            }
            input = Console.ReadLine().Split();
            if (input.Length > 0)
            {

                foreach (var item in input)
                {
                    foreach (var item2 in item)
                    {
                        if (char.IsDigit(item2)==true)
                        {
                            invalidURL = true;
                        }
                    }
                    if (invalidURL == false)
                    {
                        sPhone.Browse(item);
                    }
                    else
                    {
                        Console.WriteLine("Invalid URL!");
                        invalidURL = false;
                    }
                }
            }
        }
    }
}
