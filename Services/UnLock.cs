using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UnLock : IUnLock
    {
        public void MakeUnLock(int amountAvailable, RoomType roomType, List<Room> rooms)
        {
            rooms.ForEach(x =>
            {
                if (x.RoomType == roomType)
                {
                    x.Available = true;
                    x.AmountAvailable = amountAvailable;
                }
            });
        }
    }
}
