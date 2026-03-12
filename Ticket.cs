using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    internal abstract class Ticket : IPrint,IBook 
    {
        private static int ticketCounter = 0;
        public int ticketID { get; }
        private string _movieName;

        private decimal _price;
        public bool IsBooked { get; set; }
        public string MovieName
        {
            get { return _movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            ticketID = ticketCounter;
            _movieName = movieName;
            _price = price;
        }
        public decimal PriceAfterTax
        {
            get
            {
                return _price + (_price * 0.14m);
            }
        }
        public static int GetTotalTicketsSold()
        { return ticketCounter; }

        public void SetPrice(decimal newPrice)
        {
            Price = newPrice;
        }
        public void SetPrice(decimal basePrice , decimal multiplier)
        {
            Price = basePrice * multiplier;
        }
      
        public bool Book()
        {
           if(IsBooked)
                return false;
           IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;
            IsBooked = false;
            return true;
        }

        public abstract void Print();
        public abstract void FinalPrice();

       
      
    }

}
