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
        public string Client { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int AmountRooms { get; set; }
        public double Total { get; set; }
        public int TotalDays { get; set; }
        public Room Room { get; set; }

        public Reservation(DateTime start, DateTime end, Room room, string client)
        {
            DateStart = start;
            DateEnd = end;
            Room = room;
            TotalDays = DateEnd.Subtract(DateStart).Days;
            Client = client;
        }
    }
}
