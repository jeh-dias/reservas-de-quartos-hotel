using Domain;
using Domain.ViewModel;
using Repository.Base;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class RoomRepository : Repository<Room>
    {
        public Room GetType(RoomType roomType)
        {
            return _list.Find(x => x.RoomType.Equals(roomType));
        }

        public bool Lock(LockViewModel lockViewModel)
        {
            _list.ForEach(x =>
            {
                if (x.RoomType == lockViewModel.RoomType)
                {
                    x.Locked = true;
                    x.AmountLock = lockViewModel.Amount;
                }
            });

            return true;
        }

        public bool UnLock(UnlockViewModel unlockViewModel)
        {
            _list.ForEach(x =>
            {
                if (x.RoomType == unlockViewModel.RoomType)
                {
                    x.Locked = false;
                    x.AmountLock = (x.AmountLock - unlockViewModel.Amount);
                }
            });

            return true;
        }
    }
}
