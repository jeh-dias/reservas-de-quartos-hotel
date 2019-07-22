using System;

namespace Domain
{
    /// <summary>
    /// Classe responsável por representar a entidade quarto
    /// </summary>
    public class Room
    {
        public int Amount { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountLock { get; set; }
        public int AmountBusy { get; set; }
        public RoomType RoomType { get; set; }

        public Room(int amount, RoomType roomType)
        {
            AmountBusy = amount;
            RoomType = roomType;
        }

        public Room()
        {
        }
    }
}
