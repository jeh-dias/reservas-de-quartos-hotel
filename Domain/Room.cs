using System;

namespace Domain
{
    public class Room
    {
        public int Amount { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountLock { get; set; }
        public RoomType RoomType { get; set; }
        public bool Locked { get; set; }
        public bool Busy { get; set; }

        public bool Available { get; set; }
    }
}
