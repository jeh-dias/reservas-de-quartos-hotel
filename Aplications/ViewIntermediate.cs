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
    /// É responsável por chamar a classe que exibi os menus - view,
    /// retornar objetos após a entrada do usuário
    /// e chamar a classe de serviço - no caso projeto services
    /// </summary>
    public class ViewIntermediate
    {
        /// <summary>
        /// Opção para sair do menu do sistema
        /// </summary>
        private const int OPTION_EXIT = 7;
        private RoomService roomService;
        private ReservationService reservationService;
        private List<Room> rooms;
        private List<Reservation> reservations;

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
                        View.ClearScreen();
                        rooms = roomService.Insert(View.RegisterRooms());
                        break;
                    case 2:
                        View.ClearScreen();
                        rooms = roomService.Lock(View.LockRooms());
                        break;
                    case 3:
                        View.ClearScreen();
                        rooms = roomService.UnLock(View.UnLockRooms());
                        break;
                    case 4:
                        View.ClearScreen();
                        View.ListRooms(rooms);
                        break;
                    case 5:
                        View.ClearScreen();
                        reservations = reservationService.Insert(View.RegisterReservation(), rooms);
                        View.ClearScreen();
                        View.ReportReservations(reservations);
                        break;
                    case 6:
                        View.ClearScreen();
                        View.ReportRooms(rooms);
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
