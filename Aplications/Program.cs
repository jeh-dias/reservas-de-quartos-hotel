using Domain;
using Services;
using System;
using System.Collections.Generic;

namespace Aplications
{
    public class Program
    {
        private const int OPCTION_EXIT = 16;

        public static void Main(string[] args)
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

            var services = new HotelServices( new RoomConcret(), new Lock(), new UnLock(), new Reservation(), new Report());
            int amount = 0;

            int option = Convert.ToInt32(Console.ReadLine());
            while (option != OPCTION_EXIT)
            {
                switch (option)
                {
                    case 1:
                        amount = Convert.ToInt32(FrontEnd.InputRoomsbyType());
                        services.MakeAmountRooms(amount,RoomType.Single);
                        break;
                    case 2:
                        amount = Convert.ToInt32(FrontEnd.InputRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Standard);
                        break;
                    case 3:
                        amount = Convert.ToInt32(FrontEnd.InputRoomsbyType());
                        services.MakeAmountRooms(amount, RoomType.Lux);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                }
            }
        }
    }
}
