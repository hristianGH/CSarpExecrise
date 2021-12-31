using System;

namespace _02.Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            


   
            {
                string day = Console.ReadLine();
                switch (day)
                {
                    case "Monday":
                                                                                      // Console.WriteLine("Monday");
                                                                                     // break;
                    case "Tuesday":
                                                                           // Console.WriteLine("Tuesday");
                                                                             // break;
                    case "Wednesday":
                                                                       //  Console.WriteLine("Wednesday");
                                                                      // break;
                    case "Thursday":
                                                                       // Console.WriteLine("Thursday");
                                                                            // break;
                    case "Friday":
                                                                    // Console.WriteLine("Friday");
                        Console.WriteLine("Working day");
                        break;
                    case "Saturday":
                                                                 //Console.WriteLine("Saturday");
                                                              // break;
                    case "Sunday":
                                                                 // Console.WriteLine("Sunday");
                        Console.WriteLine("Weekend");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }

}
    

