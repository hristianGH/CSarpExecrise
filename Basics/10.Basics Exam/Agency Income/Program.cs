using System;

namespace Agency_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childTickets = int.Parse(Console.ReadLine());
            double networthAdultTicket = double.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());
            double sum;
            double netChildTicketPrice = networthAdultTicket * 0.3;
            double adultTicketPrice = networthAdultTicket + taxPrice;
           double childTicketPrice = netChildTicketPrice + taxPrice;
            sum = (childTickets * childTicketPrice) + (adultTickets * adultTicketPrice);
            sum = sum * 0.2;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {sum:f2} lv.");
        }
    }
}
