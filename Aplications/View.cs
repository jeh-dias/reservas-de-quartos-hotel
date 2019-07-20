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
            Console.WriteLine("         2 - Liberação de Quartos ");
            Console.WriteLine("         3 - Bloqueio de Quartos ");
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

        public static LockViewModel LockUnlockRooms()
        {
            Console.Write(" Entre com a quantidade ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Entre com o tipo ");
            RoomType roomtype = (RoomType)Convert.ToInt32(Console.ReadLine());

            return new LockViewModel(amount, roomtype);
        }

        public static int MenuReservation()
        {
            Console.WriteLine(" Reserva ");
            return Convert.ToInt32(Console.Read());
        }

        public static int MenuReportByRooms()
        {
            Console.WriteLine(" Relatórios por Quartos ");
            return Convert.ToInt32(Console.Read());
        }

        public static int Exit()
        {
            Console.WriteLine(" 8 - Sair ");
            return Convert.ToInt32(Console.Read());
        }
    }
}
