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
        private RoomService roomService;
        private ReservationService reservationService;
        private List<Room> rooms;
        private LockViewModel lockViewModel;
        private LockViewModel unlockViewModel;

        public ViewIntermediate()
        {
            roomService = new RoomService(new RoomBusiness());
            reservationService = new ReservationService(new ReservationBusiness());
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
                        rooms = roomService.Lock(View.LockRooms());
                        break;
                    case 3:
                        Console.Clear();
                        rooms = roomService.UnLock(View.UnLockRooms());
                        break;
                    case 4:
                        Console.Clear();
                        ListRooms(rooms);
                        break;
                    case 5:
                        Console.Clear();
                        reservationService.Insert(View.RegisterReservation());
                        break;
                    case 6:
                        Console.Clear();
                        ReportRooms(rooms);
                        break;
                    default:
                        break;
                }
            }
        }

        public static void ListRooms(List<Room> rooms)
        {
            View.ListRooms(rooms);
        }

        public static void ReportRooms(List<Room> rooms)
        {
            View.ReportRooms(rooms);
        }
    }
}
