using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Reservation
    {
        public Client Client { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int AmountRooms { get; set; }
        public double Total { get; set; }
        public RoomType roomType { get; set; }

        public TimeSpan GetAmountDays()
        {
            return DateEnd.Subtract(DateStart);
        }

        public int GetAmountRooms()
        {
            return AmountRooms;
        }

        public void SetTotal(double total)
        {
            this.Total = total;
        }

        public double GetTotal()
        {
            return this.Total;
        }
    }
}
