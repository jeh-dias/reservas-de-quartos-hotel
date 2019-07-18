using Domain;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface IUnLock
    {
        void MakeUnLock(List<Room> rooms, int amount, string roomType);
    }
}
