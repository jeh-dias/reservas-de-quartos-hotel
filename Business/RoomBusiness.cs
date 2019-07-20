using Business.Interfaces;
using Domain;
using Domain.ViewModel;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    public class RoomBusiness : IRoomBusiness
    {
        private RoomRepository _roomRepository;
        public RoomBusiness()
        {
            _roomRepository = new RoomRepository();
        }

        public bool Add(Room room)
        {

            return _roomRepository.Add(room);
        }

        public bool Lock(LockViewModel lockViewModel)
        {

            return _roomRepository.Lock(lockViewModel);
        }

        public bool UnLock(UnlockViewModel unlockViewModel)
        {

            return _roomRepository.UnLock(unlockViewModel);
        }

        public List<Room> GetList()
        {
            return _roomRepository.GetList();
        }
    }
}
