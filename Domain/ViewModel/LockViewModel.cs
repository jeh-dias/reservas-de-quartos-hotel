using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public sealed class LockViewModel
    {
        public int Amount { get; private set; }
        public RoomType RoomType { get; private set; }

        public LockViewModel(int amount, RoomType roomType)
        {
            Amount = amount;
            RoomType = roomType;
        }
    }
}
