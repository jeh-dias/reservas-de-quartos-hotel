using Aplications;
using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class ViewIntermediate
    {
        private const int OPTION_EXIT = 8;
        private static int amount;
        private HotelServices services;
        private Room room;

        public ViewIntermediate() {
            services = new HotelServices(new RoomConcret(), new Lock(), new UnLock(), new Reservation(), new Report());
        }

        public void StartReservation()
        {
            int option = 0;

            while (option != OPTION_EXIT)
            {
                FrontEnd.MenuInitial();
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        room = PackObject(FrontEnd.RegisterRooms());
                        services.AddRooms(room);
                        break;
                    case 2:
                        //amount = Convert.ToInt32(FrontEnd.MenuAvailablesRooms());
                        //services.MenuAvailablesRooms(amount, RoomType.Standard);
                        break;
                    case 3:
                        //amount = Convert.ToInt32(FrontEnd.MenuUnlockRooms());
                        //services.MakeAmountRooms(amount, RoomType.Lux);
                        break;
                    case 4:
                        //amount = Convert.ToInt32(FrontEnd.MenuLockRooms());
                        //services.MakeAmountRooms(amount, RoomType.Single);
                        break;
                    case 5:
                        //amount = Convert.ToInt32(FrontEnd.MenuReservation());
                        //services.MakeAmountRooms(amount, RoomType.Standard);
                        break;
                    case 6:
                        //amount = Convert.ToInt32(FrontEnd.MenuReportByRooms());
                        //MakeAmountRooms(amount, RoomType.Lux);
                        break;
                    case 7:
                        //amount = Convert.ToInt32(FrontEnd.MenuListAmountRommsByType());
                        services.MakeUnlocked(amount, RoomType.Single);
                        break;
                    case 8:
                        //amount = Convert.ToInt32(FrontEnd.Exit());
                        services.MakeUnlocked(amount, RoomType.Standard);
                        break;
                    default:
                        break;
                }
            }
        }

        public Room PackObject(string vet)
        {
            string[] roomObj = vet.Split(" ");
            RoomType roomType = (RoomType)Convert.ToInt32(vet[1]);

            return new Room
            {
                Amount = Convert.ToInt32(vet[0]),
                RoomType = roomType,
            };
        }
    }
}
