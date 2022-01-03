using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double studio = 0.00;
            double apartment = 0.00;
            //
            switch (month)
            {
                case "May":
                case "October":
                    studio = 50 * numNights;
                    apartment = 65 * numNights;
                    { if (numNights>7 && numNights<14)
                        {
                            studio *=0.95;
                        }
                    else if (numNights>14)
                            {
                            studio *= 0.70;
                        }
                            }
                    break;

                 case "June":
                 case "September":
                    studio = 75.20 * numNights;
                    apartment = 68.70 * numNights;
                    {
                        if(numNights > 14)
                        {
                            studio *= 0.80;
                        }
                    }
                    break;
                 case "July":
                 case "August":
                    {
                        studio = 76 * numNights;
                        apartment = 77 * numNights;
                    }
                    
                        break;
            }
            if (numNights>14)
            {
                apartment=apartment-(apartment*0.10);

            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
