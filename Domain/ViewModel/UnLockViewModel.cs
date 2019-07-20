using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public sealed class UnlockViewModel
    {
        public int Amount { get; private set; }
        public RoomType RoomType { get; private set; }

        public UnlockViewModel(int amount, RoomType roomType)
        {
            Amount = amount;
            RoomType = roomType;
        }
    }
}
