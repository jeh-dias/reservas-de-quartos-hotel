using Domain;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    /// <summary>
    /// Método responsável por todos os menus que existem no sistema
    /// </summary>
    public class View
    {
        /// <summary>
        /// Menu Inicial
        /// </summary>
        public static void MenuInitial()
        {
            Console.WriteLine("         Sistema para reservas de quartos de um hotel ");
            Console.WriteLine();
            Console.WriteLine("         Segue os números abaixo para o tipo de quarto ");
            Console.WriteLine("         1 - Single ");
            Console.WriteLine("         2 - Standard ");
            Console.WriteLine("         3 - Lux ");
            Console.WriteLine("         =================================================");
            Console.WriteLine("         1 - Cadastro de Quartos ");
            Console.WriteLine("         2 - Bloqueio de Quartos ");
            Console.WriteLine("         3 - Liberação de Quartos ");
            Console.WriteLine("         4 - Lista de Quartos ");
            Console.WriteLine("         5 - Reservas de Quartos ");
            Console.WriteLine("         6 - Relatório de Quartos ");
            Console.WriteLine("         7 - Sair ");
            Console.Write("         OP -  ");
        }

        /// <summary>
        /// Menu que responsável por cadastrar quartos
        /// </summary>
        /// <returns></returns>
        public static Room RegisterRooms()
        {
            Console.Write(" Entre com a quantidade: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo: ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new Room()
            {
                Amount = amount,
                RoomType = roomtype,
                AmountAvailable = amount
            };
        }

        /// <summary>
        /// Menu responsável por bloquear quartos
        /// </summary>
        /// <returns></returns>
        public static LockViewModel LockRooms()
        {
            Console.Write(" Entre com a quantidade: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo: ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new LockViewModel(amount, roomtype);
        }

        /// <summary>
        /// Menu responsável por liberar quartos
        /// </summary>
        /// <returns></returns>
        public static UnlockViewModel UnLockRooms()
        {
            Console.Write(" Entre com a quantidade: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo: ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new UnlockViewModel(amount, roomtype);
        }

        /// <summary>
        /// Menu responsável por reservar quartos
        /// </summary>
        /// <returns></returns>
        public static Reservation RegisterReservation()
        {
            Console.Write(" Entre com a data de inicio: ");
            DateTime dateStart = DateTime.Parse(Console.ReadLine());
            Console.Write(" Entre com a data de fim: ");
            DateTime dateEnd = DateTime.Parse(Console.ReadLine());
            Console.Write(" Entre com o nome do cliente: ");
            string client = (string)Console.ReadLine();
            Console.Write(" Entre com o tipo de quarto: ");
            RoomType roomType = (RoomType)Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com a quantidade de quartos: ");
            int amountRoom = (int)Convert.ToInt32(Console.ReadLine());

            return new Reservation(dateStart, dateEnd, new Room(amountRoom, roomType), client);
        }


        /// <summary>
        /// Menu responsável por listar quartos, 
        /// apresentando as informações tipo e quantidade
        /// <param name="rooms"></param>
        public static void ListRooms(List<Room> rooms)
        {
            Console.WriteLine();
            Console.Write("============ Lista de Quartos ==========================");
            Console.WriteLine();
            if(rooms.Count > 0)
            {
                rooms.ForEach(x =>
                {
                    Console.WriteLine($" Tipo: {x.RoomType}   ");
                    Console.WriteLine($" Quantidade: {x.Amount}");
                    Console.WriteLine();
                });
            }
            
            Console.WriteLine("========================================================");
        }

        /// <summary>
        /// Menu responsável pelo relatório de quartos
        /// Informações: tipo, travado, liberado e ocupado
        /// </summary>
        /// <param name="rooms"></param>
        public static void ReportRooms(List<Room> rooms)
        {
            Console.WriteLine();
            Console.Write("============ Relatório de Quartos ==========================");
            Console.WriteLine();
            if (rooms.Count > 0)
            {
                    rooms.ForEach(x =>
                    {
                        Console.WriteLine($" Tipo: {x.RoomType} ");
                        Console.WriteLine($" Travados: {x.AmountLock} ");
                        Console.WriteLine($" Liberados: {x.AmountAvailable}  ");
                        Console.WriteLine($" Ocupados: {x.AmountBusy}");
                        Console.WriteLine("");
                    });
            }
            Console.WriteLine("========================================================");
        }

        /// <summary>
        /// Menu responsável pelo relatório de reservas
        /// Informações: data de início, data de fim, total da reserva, tipo do quarto
        /// </summary>
        /// <param name="rooms"></param>
        public static void ReportReservations(List<Reservation> reservations)
        {
            Console.WriteLine();
            Console.Write("============ Relatório de Reservas ==============================================================");
            Console.WriteLine();
            if (reservations.Count > 0)
            {
                reservations.ForEach(x =>
                {
                    Console.WriteLine();
                    Console.WriteLine($" Cliente: {x.Client} ");
                    Console.WriteLine($" Data de Início: {x.DateStart.ToShortDateString()} ");
                    Console.WriteLine($" Data de Fim: {x.DateEnd.ToShortDateString()} ");
                    Console.WriteLine($" Total de Dias: {x.TotalDays} ");
                    Console.WriteLine($" Tipo de Quarto: {x.Room.RoomType.ToString()}  ");
                    Console.WriteLine($" Valor Total da Diaria: R$ {x.Total},00");
                    Console.WriteLine("");
                });
            }
            Console.WriteLine("===============================================================================================");
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
