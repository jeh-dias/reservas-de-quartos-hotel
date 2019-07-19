using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public interface IRoom
    {
        void AddAmountRoomsByType(int amount, RoomType roomType, List<Room> rooms);
        void AddAmountAvailableRoomsByType(int amount, RoomType roomType, List<Room> rooms);

        void ListAllRooms(List<Room> rooms);
    }
}
