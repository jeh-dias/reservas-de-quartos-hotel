using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável pela entidade de reserva
    /// </summary>
    public class Reservation
    {
        public Client Client { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int AmountRooms { get; set; }
        public double Total { get; set; }
        public int TotalDays { get; set; }
        public RoomType RoomType { get; set; }
        public Price price { get; set; }

        public Reservation(DateTime start, DateTime end, int amountRooms, RoomType roomType)
        {
            DateStart = start;
            DateEnd = end;
            AmountRooms = amountRooms;
            RoomType = roomType;
            TotalDays = DateEnd.Subtract(DateStart).Days;
        }

        public int GetAmountRooms()
        {
            return AmountRooms;
        }
    }
}
