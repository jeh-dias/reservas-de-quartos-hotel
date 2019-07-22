using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    /// <summary>
    /// ViewModel responsável por tipar os dados de um quarto liberado
    /// </summary>
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
