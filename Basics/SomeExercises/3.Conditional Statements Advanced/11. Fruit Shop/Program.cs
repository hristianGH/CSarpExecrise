using System;
using System.Security.Cryptography;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            double price = 0.0;
            switch (day)
            {

                case ("Monday"):
                case ("Tuesday"):
                case ("Wednesday"):
                case ("Thursday"):
                case ("Friday"):
                    {
                        switch (fruit)
                        {
                            case ("banana"):
                                price = 2.50 * num;
                                Console.WriteLine(price);
                                break;
                            case ("apple"):
                                price = 1.20 * num;
                                Console.WriteLine(price);
                                break;
                            case ("orange"):
                                price = 0.85 * num;
                                Console.WriteLine(price);
                                break;
                            case ("grapefruit"):
                                price = 1.45 * num;
                                Console.WriteLine(price);
                                break;
                            case ("kiwi"):
                                price = 2.70 * num;
                                Console.WriteLine(price);
                                break;
                            case ("pineapple"):
                                price =5.50 * num;
                                Console.WriteLine(price);
                                break;
                            case ("grapes"):
                                price = 3.85 * num;
                                Console.WriteLine(price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {

                    }
                    {
                        switch (fruit)
                        {
                            case ("banana"):
                                price = 2.70 * num;
                                Console.WriteLine(price);
                                break;
                            case ("apple"):
                                price = 1.25 * num;
                                Console.WriteLine(price);
                                break;
                            case ("orange"):
                                price = 0.90 * num;
                                Console.WriteLine(price);
                                break;
                            case ("grapefruit"):
                                price = 3.00 * num;
                                Console.WriteLine(price);
                                break;
                            case ("kiwi"):
                                price = 5.60 * num;
                                Console.WriteLine(price);
                                break;
                            case ("pineapple"):
                                price = 5.60 * num;
                                Console.WriteLine( price: f2);
                                break;
                            case ("grapes"):
                                price = 4.20 * num;
                                Console.WriteLine($"{price:f2}");
                                break;

                            default:
                                Console.WriteLine("error");
                                break;
                        }
                        break;

                    }
                    
                   
                default:
                    Console.WriteLine("error");
                    break;


            }





        }
    }
}