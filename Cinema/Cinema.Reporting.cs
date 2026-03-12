using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal partial class Cinema
    {
        public string CinemaName { get; set; }

        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();



        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ====");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
            Console.WriteLine("=== Cinema Closed ===");
            
        }

       

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var t in tickets)
            {
                if (t != null)
                {
                    t.Print();
                    Console.WriteLine();
                }

            }
        }

        
    }

}
