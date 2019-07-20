using Domain;
using Repository.Base;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class RoomRepository : Repository<Room>
    {
        public Room GetType(RoomType roomType)
        {
            return _list.Find(x =>x.RoomType.Equals(roomType));
        }
    }
}
