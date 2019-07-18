using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UnLock : IUnLock
    {
        public void MakeUnLock(List<Room> rooms, int amount, string roomType)
        {
            var listType = rooms.FindAll(x => x.RoomType.ToString().Equals(roomType));
            for (int i = 0; i < amount; i++)
            {
                listType[i].Locked = false;
            }
        }
    }
}
