using Domain;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface IUnLock
    {
        void MakeUnLock(int amount, RoomType roomType, List<Room> rooms);
    }
}
