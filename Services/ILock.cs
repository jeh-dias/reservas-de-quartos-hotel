using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ILock
    {
        void MakeLock(List<Room> rooms, int amount, string roomType);
    }
}
