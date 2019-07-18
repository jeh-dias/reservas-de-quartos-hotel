using System;

namespace Domain
{
    public class Room
    {
        public int Amount { get; set; }
        public RoomType RoomType { get; set; }
        public bool Locked { get; set; }
        public bool Busy { get; set; }
    }
}
