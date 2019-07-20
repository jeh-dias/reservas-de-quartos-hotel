using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplications
{
    public static class FrontEnd
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
            Console.WriteLine("         2 - Lista de Quartos ");
            Console.WriteLine("         3 - Reservas de Quartos ");
            Console.WriteLine("         4 - Relatório de Quartos ");
            Console.WriteLine("         5 - Liberação de Quartos ");
            Console.WriteLine("         6 - Bloqueio de Quartos ");
            Console.WriteLine();
        }

        public static string RegisterRooms()
        {
            Console.WriteLine(" Entre com a quantidade e o tipo ");
            return Console.Read().ToString();
        }

        public static int MenuUnlockRooms()
        {
            Console.WriteLine(" Entre com a quantidade e o tipo do quarto liberado ");
            return Convert.ToInt32(Console.Read());
        }

        public static int MenuLockRooms()
        {
            Console.WriteLine(" Entre com a quantidade e o tipo do quarto travado ");
            return Convert.ToInt32(Console.Read());
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
