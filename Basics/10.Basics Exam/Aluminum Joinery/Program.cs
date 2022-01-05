using System;

namespace Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double windowPrice = 0; 
            int windowCount = int.Parse(Console.ReadLine());
            string typeWindow=  Console.ReadLine();
            if (typeWindow=="90X130")
            {
                windowPrice = 110;
                if (windowCount>30)
                {
                    windowPrice = windowPrice * 0.95;
                }
                else if (windowCount>60)
                {
                    windowPrice = windowPrice * 0.92;
                }
            }
            else if (typeWindow == "100X150")
            {
                windowPrice = 140;
                if (windowCount > 40)
                {
                    windowPrice = windowPrice * 0.94;
                }
                else if (windowCount > 80)
                {
                    windowPrice = windowPrice * 0.90;
                }
            }
            else if (typeWindow == "130X180")
            {
                windowPrice = 190;
                if (windowCount > 20)
                {
                    windowPrice = windowPrice * 0.93;
                }
                else if (windowCount > 50)
                {
                    windowPrice = windowPrice * 0.88;
                }
            }
            else if (typeWindow == "200X300")
            {
                windowPrice = 250;
                if (windowCount > 25)
                {
                    windowPrice = windowPrice * 0.91;
                }
                else if (windowCount > 50)
                {
                    windowPrice = windowPrice * 0.86;
                }
            }
            if (windowCount<10)
            {
                Console.WriteLine("Invalid order");
                Environment.Exit(0);
            }
            if (windowCount>99)
            {
                windowPrice = windowPrice * 0.04;
            }
            string typeDelivery= Console.ReadLine();
            bool delivery = typeDelivery == "With Delivery";
            double sum = windowCount * windowPrice;
            if (delivery)
            {
                sum += 60;
            }
            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
