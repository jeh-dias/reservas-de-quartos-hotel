using System;
using System.Collections.Generic;
using System.Text;
using Business.Interfaces;
using Domain;
using Domain.ViewModel;

namespace Services
{
    public class RoomService
    {
        private readonly IRoomBusiness _roomBusiness;
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

        public void List(List<Room> rooms)
        {
            Console.Write("============Lista de Quartos ==========================");
            Console.WriteLine();
            foreach (var room in rooms)
            {
                Console.Write($" Tipo:{room.RoomType}    Quantidade: {room.Amount}");
                Console.WriteLine();
            }
            Console.WriteLine("========================================================");
        }
    }
}
