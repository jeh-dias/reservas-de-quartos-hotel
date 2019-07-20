using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ILock
    {
        void MakeLock(int amount, RoomType roomType, List<Room> rooms);
    }
}
