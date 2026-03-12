using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal static class TicketExtensions
    {
        public static void GenerateReceipt(this Ticket ticket)
        {
            Console.WriteLine("\n=========== RECEIPT ===========");
            Console.WriteLine($"Movie   :{ticket.MovieName}");
            Console.WriteLine($"Type    :{ticket.GetType().Name}");
            Console.WriteLine($"Price   :{ticket.Price}");
            Console.WriteLine($"Final   :{ticket.PriceAfterTax}");
            Console.WriteLine($"Status  :{((ticket.IsBooked)?"Booked" : "Available")}");
            Console.WriteLine("========================");
        }

        public static void TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;
            foreach (Ticket ticket in tickets)
            {
                total += ticket.PriceAfterTax;
            }

            Console.WriteLine($"Total Revenue: {total}\n");
        }
    }
}
