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

        //public Room GetType(RoomType roomType)
        //{
        //    return _list.Find(x => x.RoomType.Equals(roomType));
        //}

        /// <summary>
        /// Recebe a view model com os dados do quarto a ser bloqueado
        /// e insere a quantidade de bloqueio
        /// </summary>
        /// <param name="lockViewModel"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Recebe a view model com os dados do quarto a ser liberado
        /// e insere a quantidade de bloqueio
        /// </summary>
        /// <param name="lockViewModel"></param>
        /// <returns></returns>
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
