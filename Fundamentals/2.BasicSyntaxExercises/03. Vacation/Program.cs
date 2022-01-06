using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfClient = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double priceSum = 0;
            double discount = 1;
            bool fkingTru = false;
            switch (day)
            {
                case "Friday":
                    if (typeOfClient=="Students")
                    {
                        price = 8.45;
                    }
                    else if  (typeOfClient == "Business")
                    {
                        price = 10.90;
                    }
                    else
                    {
                        price = 15.00;
                    }
                    break;

                case "Saturday":
                    if (typeOfClient == "Students")
                    {
                        price = 9.80;
                    }
                    else if (typeOfClient == "Business")
                    {
                        price = 15.60;
                    }
                    else
                    {
                        price = 20.00;
                    }
                    break;
                case "Sunday":
                    if (typeOfClient == "Students")
                    {
                        price = 10.46;
                    }
                    else if (typeOfClient == "Business")
                    {
                        price = 16.00;
                    }
                    else 
                    {
                        price = 22.50;
                    }
                    break;
            }
            if (groupSize>=30 && typeOfClient=="Students")
            {
                discount = 0.85;
            }

            else if (groupSize>=10 && groupSize<=20 && typeOfClient=="Regular")
            {
                discount = 0.95;
            }
            if (groupSize >= 100 && typeOfClient == "Bussiness")
            {
                fkingTru = true;
                priceSum=(price * groupSize) * discount;
                priceSum -= 10 * price;
            }
          
            if (fkingTru==false)
            {
                priceSum = (price * groupSize) * discount;
            }
            Console.WriteLine($"Total price: {priceSum:f2}");
        }

    }
}
