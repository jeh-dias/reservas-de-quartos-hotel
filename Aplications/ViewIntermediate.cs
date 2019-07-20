using Aplications;
using Business;
using Domain;
using Domain.ViewModel;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class ViewIntermediate
    {
        private const int OPTION_EXIT = 8;
        private RoomBusiness roomBusiness;
        private RoomService roomService;
        private List<Room> rooms;
        private LockViewModel lockViewModel;
        private LockViewModel unlockViewModel;

        public ViewIntermediate()
        {
            roomBusiness = new RoomBusiness();
            roomService = new RoomService(roomBusiness);
        }

        public void StartReservation()
        {
            int option = 0;

            while (option != OPTION_EXIT)
            {
                View.MenuInitial();
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        rooms = roomService.Insert(View.RegisterRooms());
                        break;
                    case 2:
                        Console.Clear();
                        rooms = roomService.Lock(View.LockUnlockRooms());
                        break;
                    case 3:
                        Console.Clear();
                        //rooms = roomService.UnLock(View.UnlockUnlockRooms());
                        break;
                    case 4:
                        Console.Clear();
                        roomService.List(rooms);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
