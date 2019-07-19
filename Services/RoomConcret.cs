using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class RoomConcret : IRoom
    {
        public void AddAmountAvailableRoomsByType(int amount, RoomType roomType, List<Room> rooms)
        {
            rooms.Add(
                new Room
                {
                    Amount = amount,
                    RoomType = roomType,
                    Available = true
                }
            );
        }

        public void AddAmountRoomsByType(int amount, RoomType roomType, List<Room> rooms)
        {
            rooms.Add(
                new Room
                {
                    Amount = amount,
                    RoomType = roomType
                }
            );
        }

        public void ListAllRooms(List<Room> rooms)
        {
            Console.WriteLine("Quantidade de quartos por Tipo ");
            Console.WriteLine("Quantidade de quartos " + RoomType.Single + rooms.Find(x => x.RoomType.Equals(RoomType.Single)).Amount);
            Console.WriteLine("Quantidade de quartos " + RoomType.Standard + rooms.Find(x => x.RoomType.Equals(RoomType.Standard)).Amount);
            Console.WriteLine("Quantidade de quartos " + RoomType.Lux + rooms.Find(x => x.RoomType.Equals(RoomType.Lux)).Amount);
        }
    }
}
