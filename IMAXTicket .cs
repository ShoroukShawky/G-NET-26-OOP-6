using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, decimal price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;

            if (Is3D)
                Price += 30;
        }


        public override void Print()
        {
            Console.WriteLine($"[Ticket #{ticketID}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | Final: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void FinalPrice()
        {
            Console.WriteLine($"IMAXTicket => Final Price: {PriceAfterTax}");
        }
    }
}
