using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplications
{
    public static class FrontEnd
    {
        public static void Title()
        {
            Console.WriteLine("         Sistema para reservas de quartos de um hotel ");
            Console.WriteLine();
        }

        public static void MenuRooms()
        {
            Console.WriteLine(" Entre com a quantidade de quartos para cada tipo ");
            Console.WriteLine("     1 - Quarto Single  ");
            Console.WriteLine("     2 - Quarto Standard  ");
            Console.WriteLine("     3 - Quarto Lux  ");
        }

        public static void MenuAvailablesRooms()
        {
            Console.WriteLine(" Entre com a quantidade de quartos disponíveis para cada tipo ");
            Console.WriteLine("     4 - Quarto Single  ");
            Console.WriteLine("     5 - Quarto Standard  ");
            Console.WriteLine("     6 - Quarto Lux  ");
        }

        public static int InputRoomsbyType()
        {
            Console.WriteLine(" Entre com a quantidade de quartos ");
            return Convert.ToInt32(Console.Read());
        }

        public static int InputAvailablesRoomsbyType()
        {
            Console.WriteLine(" Entre com a quantidade de quartos disponíveis ");
            return Convert.ToInt32(Console.Read());
        }

        public static void MenuUnlockRooms()
        {
            Console.WriteLine(" Liberar quartos por tipo ");
            Console.WriteLine("     7 - Quarto " + RoomType.Single.ToString());
            Console.WriteLine("     8 - Quarto " + RoomType.Standard.ToString());
            Console.WriteLine("     9 - Quarto " + RoomType.Lux.ToString());
        }

        public static int InputAmountAvailablesRooms()
        {
            Console.WriteLine("Entre com a quantidade de quartos liberados ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void MenuLockRooms()
        {
            Console.WriteLine(" Travar quartos por tipo ");
            Console.WriteLine("     10 - Quarto " + RoomType.Single.ToString());
            Console.WriteLine("     11 - Quarto " + RoomType.Standard.ToString());
            Console.WriteLine("     12 - Quarto " + RoomType.Lux.ToString());
        }

        public static int InputAmountLockRooms()
        {
            Console.WriteLine(" Entre com a quantidade de quartos travados ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void MenuReservation()
        {
            Console.WriteLine("     13 - Reserva ");
            //Console.WriteLine("Entre com as informações para a Reserva ");
            //Console.WriteLine("Entre com a data de início e fim ");
            //Console.WriteLine("Entre com os dados do cliente ");
            //return Convert.ToInt32(Console.ReadLine());
        }

        public static void MenuReportByRooms()
        {
            Console.WriteLine("     14 - Relatórios por Quartos ");
        }

        public static void MenuListAmountRommsByType()
        {
            Console.WriteLine("     15 - Listar Quantidade de Quartos Por Tipo ");
            //Console.WriteLine("Quantidades de Quartos Single => " + roomsSingle);
            //Console.WriteLine("Quantidades de Quartos Standard => " + roomsStandard);
            //Console.WriteLine("Quantidades de Quartos Lux => " + roomsLuxo);
        }

        public static void Exit()
        {
            Console.WriteLine("     16 - Sair ");
            //return Convert.ToInt32(Console.ReadLine());
        }
    }
}
