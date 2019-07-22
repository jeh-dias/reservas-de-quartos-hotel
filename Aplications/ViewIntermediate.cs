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
    /// <summary>
    /// É responsável por chamar a classe que possue os menus - view,
    /// retornar objetos após a entrada do usuário
    /// e chamar a classe de serviço - no caso projeto services
    /// </summary>
    public class ViewIntermediate
    {
        private const int OPTION_EXIT = 8;
        private RoomService roomService;
        private ReservationService reservationService;
        private List<Room> rooms;
        private LockViewModel lockViewModel;
        private LockViewModel unlockViewModel;

        /// <summary>
        /// Criação dos objetos de services e business
        /// </summary>
        public ViewIntermediate()
        {
            roomService = new RoomService(new RoomBusiness());
            reservationService = new ReservationService(new ReservationBusiness());
        }

        /// <summary>
        /// Chamada para service e operações que estão na view
        /// como relatório e listagem dos quartos
        /// </summary>
        public void StartChoices()
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
                        View.ListRooms(rooms);
                        break;
                    case 5:
                        Console.Clear();
                        reservationService.Insert(View.RegisterReservation());
                        break;
                    case 6:
                        Console.Clear();
                        View.ReportRooms(rooms);View.ReportRooms(rooms);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
