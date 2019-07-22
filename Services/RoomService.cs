using System;
using System.Collections.Generic;
using System.Text;
using Business.Interfaces;
using Domain;
using Domain.ViewModel;

namespace Services
{
    /// <summary>
    /// Classe responsável por receber informações da view
    /// e enviar para a classe de regra de negócio
    /// </summary>
    public class RoomService
    {
        private readonly IRoomBusiness _roomBusiness;
        /// <summary>
        /// A interface IRoomBusiness é responsável
        /// por chamar o repositório
        /// </summary>
        /// <param name="roomBusiness"></param>
        public RoomService(IRoomBusiness roomBusiness)
        {
            _roomBusiness = roomBusiness;
        }

        public List<Room> Insert(Room room)
        {
            _roomBusiness.Add(room);
            return _roomBusiness.GetList();
        }

        public List<Room> Lock(LockViewModel lockViewModel)
        {
            _roomBusiness.Lock(lockViewModel);
            return _roomBusiness.GetList();
        }

        public List<Room> UnLock(UnlockViewModel unlockViewModel)
        {
            _roomBusiness.UnLock(unlockViewModel);
            return _roomBusiness.GetList();
        }
    }
}
