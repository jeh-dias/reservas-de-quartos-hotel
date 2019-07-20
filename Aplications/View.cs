using Domain;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class View
    {
        public static void MenuInitial()
        {
            Console.WriteLine("         Sistema para reservas de quartos de um hotel ");
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

        public static Room RegisterRooms()
        {
            Console.Write(" Entre com a quantidade ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new Room
            {
                Amount = amount,
                RoomType = roomtype
            };
        }

        public static LockViewModel LockRooms()
        {
            Console.Write(" Entre com a quantidade ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new LockViewModel(amount, roomtype);
        }

        public static UnlockViewModel UnLockRooms()
        {
            Console.Write(" Entre com a quantidade ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new UnlockViewModel(amount, roomtype);
        }

        public static Reservation RegisterReservation()
        {
            Console.WriteLine(" Entre com a data de inicio: ");
            DateTime dateStart = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com a data de fim: ");
            DateTime dateEnd = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(" Entre com o nome do cliente: ");
            //string client = (String)Console.ReadLine();
            Console.WriteLine(" Entre com o tipo de quarto: ");
            RoomType roomType = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new Domain.Reservation
            {
                DateStart = dateStart,
                DateEnd = dateEnd,
                roomType = roomType
            };
        }

        public static void ListRooms(List<Room> rooms)
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

        public static void ReportRooms(List<Room> rooms)
        {
            Console.Write("============Relatório de Quartos ==========================");
            Console.WriteLine();
            foreach (var room in rooms)
            {
                Console.Write($" Tipo:{room.RoomType}  =>  Travados: {room.AmountLock}  Liberados: {room.AmountAvailable}  Ocupados: {room.AmountBusy}");
                Console.WriteLine("");
            }
            Console.WriteLine("========================================================");
        }
    }
}
