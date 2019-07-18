using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ReservationDomain
    {
        private Client Client { get; set; }
        private DateTime DateStart { get; set; }
        private DateTime DateEnd { get; set; }
        private int AmountRooms { get; set; }
        private double Total { get; set; }
        private RoomType roomType { get; set; }

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
