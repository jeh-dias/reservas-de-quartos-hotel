using Domain;
using Services;
using System;
using System.Collections.Generic;

namespace Aplications
{
    public class Program
    {
        private const int OPTION_EXIT = 16;

        public static void Main(string[] args)
        {
            var services = new HotelServices(new RoomConcret(), new Lock(), new UnLock(), new Reservation(), new Report());
            int amount;
            MenuInitial();
            int option = Convert.ToInt32(Console.ReadLine());

            while (option != OPTION_EXIT)
            {
                amount = 0;
                switch (option)
                {
                    case 1:
                        amount = Convert.ToInt32(FrontEnd.InsertRoomsbyType());
                        services.MakeAmountRooms(amount,RoomType.Single);
                        break;
                    case 2:
                        amount = Convert.ToInt32(FrontEnd.InsertRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Standard);
                        break;
                    case 3:
                        amount = Convert.ToInt32(FrontEnd.InsertRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Lux);
                        break;
                    case 4:
                        amount = Convert.ToInt32(FrontEnd.InsertAvailablesRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Single);
                        break;
                    case 5:
                        amount = Convert.ToInt32(FrontEnd.InsertAvailablesRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Standard);
                        break;
                    case 6:
                        amount = Convert.ToInt32(FrontEnd.InsertAvailablesRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Lux);
                        break;
                    case 7:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountAvailablesRooms());
                        services.MakeUnlocked(amount, RoomType.Single);
                        break;
                    case 8:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountAvailablesRooms());
                        services.MakeUnlocked(amount, RoomType.Standard);
                        break;
                    case 9:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountAvailablesRooms());
                        services.MakeUnlocked(amount, RoomType.Lux);
                        break;
                    case 10:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountLockRooms());
                        services.MakeLocked(amount, RoomType.Single);
                        break;
                    case 11:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountLockRooms());
                        services.MakeLocked(amount, RoomType.Standard);
                        break;
                    case 12:
                        amount = Convert.ToInt32(FrontEnd.InsertAmountLockRooms());
                        services.MakeLocked(amount, RoomType.Lux);
                        break;
                    case 13:
                        break;
                    case 14:
                        services.MakeReport();
                        break;
                    case 15:
                        services.ListRooms();
                        break;
                    case 16:
                        break;
                    default:
                        break;
                }
            }
        }
        public static void MenuInitial()
        {
            FrontEnd.Title();
            FrontEnd.MenuRooms();
            FrontEnd.MenuAvailablesRooms();
            FrontEnd.MenuUnlockRooms();
            FrontEnd.MenuLockRooms();
            FrontEnd.MenuReservation();
            FrontEnd.MenuReportByRooms();
            FrontEnd.MenuListAmountRommsByType();
            FrontEnd.Exit();
        }
    }
}
