using Domain;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface base para a classe de regra de negócio de um quarto
    /// </summary>
    public interface IRoomBusiness
    {
        bool Add(Room room);

        bool Lock(LockViewModel lockViewModel);

        bool UnLock(UnlockViewModel unlockViewModel);

        List<Room> GetList();
    }
}
