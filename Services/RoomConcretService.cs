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
            throw new NotImplementedException();
        }

        public void AddRooms(int amount, RoomType roomType)
        {
            throw new NotImplementedException();
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
