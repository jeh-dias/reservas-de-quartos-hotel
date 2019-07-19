using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Lock : ILock
    {
        public void MakeLock(int amountLock, RoomType roomType, List<Room> rooms)
        {
            rooms.ForEach(x =>
            {
                if (x.RoomType == roomType)
                {
                    x.Locked = true;
                    x.AmountLock = amountLock;
                }
            });
        }
    }
}
