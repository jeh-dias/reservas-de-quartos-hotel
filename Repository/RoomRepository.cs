using Domain;
using Domain.ViewModel;
using Repository.Base;
using System;
using System.Collections.Generic;

namespace Repository
{
    /// <summary>
    /// Repositório responsável pelo 
    /// bloqueio e liberação de um quarto
    /// </summary>
    public class RoomRepository : Repository<Room>
    {
        /// <summary>
        /// Responsável por receber a view model com os dados do quarto a ser bloqueiado
        /// e realizar o bloqueio
        /// </summary>
        /// <param name="lockViewModel"></param>
        /// <returns></returns>
        public bool Lock(LockViewModel lockViewModel)
        {
            _list.ForEach(x =>
            {
                if (x.RoomType == lockViewModel.RoomType)
                {
                    x.AmountLock = lockViewModel.Amount;
                    x.AmountAvailable -= lockViewModel.Amount;
                }
            });

            return true;
        }

        /// <summary>
        /// Responsável por receber a view model com os dados do quarto a ser liberado
        /// e realizar a liberação
        /// </summary>
        /// <param name="lockViewModel"></param>
        /// <returns></returns>
        public bool UnLock(UnlockViewModel unlockViewModel)
        {
            _list.ForEach(x =>
            {
                if (x.RoomType == unlockViewModel.RoomType)
                {
                    x.AmountLock = (x.AmountLock - unlockViewModel.Amount);
                    x.AmountAvailable += unlockViewModel.Amount;
                }
            });
            return true;
        }
    }
}
