using Business.Interfaces;
using Domain;
using Domain.ViewModel;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Responsável pela regra de negócios de um quarto
    /// </summary>
    public class RoomBusiness : IRoomBusiness
    {
        private RoomRepository _roomRepository;
        public RoomBusiness()
        {
            _roomRepository = new RoomRepository();
        }

        /// <summary>
        /// Chamada para o repositório realizar a inserção do objeto 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool Add(Room room)
        {
            return _roomRepository.Add(room);
        }

        /// <summary>
        /// Chamada para o repositório realizar o bloqueio de um quarto
        /// </summary>
        /// <returns></returns>
        public bool Lock(LockViewModel lockViewModel)
        {

            return _roomRepository.Lock(lockViewModel);
        }

        /// <summary>
        /// Chamada para o repositório realizar a liberação de um quarto
        /// </summary>
        /// <returns></returns>
        public bool UnLock(UnlockViewModel unlockViewModel)
        {
            return _roomRepository.UnLock(unlockViewModel);
        }

        /// <summary>
        /// Chamada para o repositório realizar a listagem da lista de objeto 
        /// </summary>
        /// <returns></returns>
        public List<Room> GetList()
        {
            return _roomRepository.GetList();
        }
    }
}
