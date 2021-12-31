using System;
using System.Linq.Expressions;
using System.Threading;

namespace _11._Fruit_Shop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string date = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            double sum = 0.00;
            //
            switch(date)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch(fruit)
                    {
                        case ("banana"):
                            sum = 2.50 * num;
                            break;
                        case ("apple"):
                            sum = 1.20 * num;
                            break;
                        case ("orange"):
                            sum = 0.85 * num;
                            break;
                        case ("grapefruit"):
                            sum = 1.45 * num;
                            break;
                        case ("kiwi"):
                            sum = 2.70 * num;
                            break;
                        case ("pineapple"):
                            sum = 5.50 * num;
                            break;
                        case ("grapes"):
                            sum = 3.85 * num;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                   case "Saturday":
                    case "Sunday":
                    switch(fruit)
                    {
                        case ("banana"):
                            sum = 2.70 * num;
                            break;
                        case ("apple"):
                            sum = 1.25 * num;
                            break;
                        case ("orange"):
                            sum = 0.90 * num;
                            break;
                        case ("grapefruit"):
                            sum = 1.60 * num;
                            break;
                        case ("kiwi"):
                            sum = 3.00 * num;
                            break;
                        case ("pineapple"):
                            sum = 5.60 * num;
                            break;
                        case ("grapes"):
                            sum = 4.20 * num;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                           default:
                    {
                        Console.WriteLine("error");
                    }
                    break;
                  
                    
            }

            if (sum > 0)
            {
                Console.WriteLine();



                Console.WriteLine($"{sum:f2}");
            }
        }


    }
}
