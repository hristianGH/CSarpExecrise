using System;
using System.Reflection.PortableExecutable;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string produkt = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            
            //
            switch (city)
                {
                case "Sofia":
                    if(produkt=="coffee")
                        {
                        Console.WriteLine(quantity *0.50);
                    }
                    else if(produkt=="water")
                    {
                        Console.WriteLine(quantity*0.80);
                    }else if(produkt=="beer")
                    {
                        Console.WriteLine(quantity*1.20);
                    }
                     else if(produkt=="sweets")
                    {
                        Console.WriteLine(quantity*1.45);
                    }
                     else if(produkt =="peanuts")
                    {
                        Console.WriteLine(quantity*1.60);
                    }
                    break;  case "Plovdiv":
                    if(produkt=="coffee")
                        {
                        Console.WriteLine(quantity *0.40);
                    }
                    else if(produkt=="water")
                    {
                        Console.WriteLine(quantity*0.70);
                    }else if(produkt=="beer")
                    {
                        Console.WriteLine(quantity*1.15);
                    }
                     else if(produkt=="sweets")
                    {
                        Console.WriteLine(quantity*1.30);
                    }
                     else if(produkt =="peanuts")
                    {
                        Console.WriteLine(quantity*1.50);
                    }
                    break;  case "Varna":
                    if(produkt=="coffee")
                        {
                        Console.WriteLine(quantity *0.45);
                    }
                    else if(produkt=="water")
                    {
                        Console.WriteLine(quantity*0.70);
                    }else if(produkt=="beer")
                    {
                        Console.WriteLine(quantity*1.10);
                    }
                     else if(produkt=="sweets")
                    {
                        Console.WriteLine(quantity*1.35);
                    }
                     else if(produkt =="peanuts")
                    {
                        Console.WriteLine(quantity*1.55);
                    }
                    break;
                    Console.WriteLine(Math.Round());
                 //   case "Plovdiv":
                 //   case "Varna":
                 //   break;
                 //

            }
           // switch (produkt)
            {
             //   case "coffee":
             //   case "water":
             //   case "beer":
              //  case "sweets":
              //  case "peanuts":
                //    break;
                    
            }

                


        }
    }
}
