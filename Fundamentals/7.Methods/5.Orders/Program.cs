using System;
using System.Linq;

namespace _5.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
          

        }
        public static double Order(string input,int quantity)
        {
            if (input.ToLower() == "coffee")
            {
                return 1.5 * quantity;
            }
            else if (input.ToLower() == "coke")
            {
                return 1.4 * quantity;
            }
            else if (input.ToLower() == "snacks")
            {
                return 2.0 * quantity;
            }
            return 1.0 * quantity;
        }
    }

}
