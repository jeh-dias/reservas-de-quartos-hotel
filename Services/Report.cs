using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Report : IReport
    {
        public void MakeReport(List<Room> rooms)
        {
            var amountRooms = rooms.Count;

            var roomsLocks = rooms.FindAll(x => x.Locked).Count;
            var roomsBusys = rooms.FindAll(x => x.Busy).Count;
            var roomsAvailables = rooms.FindAll(x => !x.Locked && !x.Busy).Count;

            var lockedsCount = GetAmountPercent(amountRooms, roomsLocks);
            var busiesCount = GetAmountPercent(amountRooms, roomsBusys);
            var availablesCount = GetAmountPercent(amountRooms, roomsAvailables);

            Console.WriteLine(" Quartos Liberados => " + availablesCount);
            Console.WriteLine(" Quartos Ocupados => " + busiesCount);
            Console.WriteLine(" Quartos Travados => " + lockedsCount);
        }

        public static double GetAmountPercent(int amount, int amountType)
        {
            return amount / amountType;
        }
    }
}
