using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class RoomConcret : IRoom
    {
        private List<Room> rooms = new List<Room>();

        public void AddAmountAvailableRoomsByType()
        {
            throw new NotImplementedException();
        }

        public void AddAmountRoomsByType(int amount, RoomType roomType)
        {
            rooms.Add(
                new Room
                {
                    Amount = amount,
                    RoomType = roomType
                }
            );
        }
    }
}
