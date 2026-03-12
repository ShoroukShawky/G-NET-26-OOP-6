using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal class VIPTicket : Ticket 
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movie, decimal price, bool lounge)
      : base(movie, price)
        {
            LoungeAccess = lounge;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{ticketID}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void FinalPrice()
        {
            Console.WriteLine($"VIPTicket => Final Price: {PriceAfterTax}");
        }

    }
}
