using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal class StandardTicket:Ticket

    {
       
            public string SeatNumber { get; set; }

            public StandardTicket(string movie, decimal price, string seat)
                : base(movie, price)
            {
                SeatNumber = seat;
            }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{ticketID}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void FinalPrice()
        {
            Console.WriteLine($"StandardTicket => Final Price: {PriceAfterTax}");
        }
    }
    }

