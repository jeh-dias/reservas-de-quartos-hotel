using Business.Interfaces;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    /// <summary>
    /// Responsável pela regra de negócios da entidade reserva
    /// </summary>
    public class ReservationBusiness : IReservationBusiness
    {
        /// <summary>
        /// Porcentagem para o desconto - 10%
        /// </summary>
        private const double DESCONTO_DEZ_POR_CENTO = 0.10;
        /// <summary>
        /// Quantidade de diárias que possum desconto
        /// </summary>
        private const double DIARIAS_COM_DESCONTO = 5;

        private ReservationRepository _reservationRepository;
        private static Dictionary<int, double> priceRoomType = new Dictionary<int, double>();

        public ReservationBusiness()
        {
            _reservationRepository = new ReservationRepository();
            priceRoomType.Add(1, 230);
            priceRoomType.Add(2, 310);
            priceRoomType.Add(3, 470);
        }

        /// <summary>
        /// Chamada para o repositório realizar a inserção do objeto 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool Add(Reservation reservation, List<Room> rooms)
        {
            ReservationRoom(reservation, rooms);
            CalculateTotalReservation(reservation);
            return _reservationRepository.Add(reservation);
        }

        /// <summary>
        /// Chamada para o repositório realizar a listagem da lista de objeto 
        /// </summary>
        /// <returns></returns>
        public List<Reservation> GetList()
        {
            return _reservationRepository.GetList();
        }

        /// <summary>
        /// Retorno do valor da diária com base no tipo de quarto
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        private static double GetPrice(Reservation reservation)
        {
            return priceRoomType[(int)reservation.Room.RoomType];
        }
        /// <summary>
        /// Cálculo do valor total da diária
        /// </summary>
        /// <param name="reservation"></param>
        private static void CalculateTotalReservation(Reservation reservation)
        {
            double reservationTotal = (double)reservation.TotalDays * (double)GetPrice(reservation);

            if (reservation.TotalDays > DIARIAS_COM_DESCONTO)
            {
                reservation.Total = CalculateDiscount(reservation, reservationTotal);
            }
            else
            {
                reservation.Total = reservationTotal;
            }
        }

        /// <summary>
        /// Cálculo do desconto para a quantidade de diárias acima de cinco
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        private static double CalculateDiscount(Reservation reservation, double reservationTotal)
        {
            double discount =  reservationTotal * DESCONTO_DEZ_POR_CENTO;
            return reservationTotal - discount;
        }

        /// <summary>
        /// Método responsável por realizar a reserva do quarto
        /// </summary>
        private static void ReservationRoom(Reservation reservation, List<Room> rooms)
        {
            rooms.ForEach(x =>
            {
                if (x.RoomType == reservation.Room.RoomType)
                {
                    x.AmountBusy = reservation.Room.AmountBusy;
                    x.AmountAvailable = x.AmountAvailable - x.AmountBusy;
                }
            });
        }
    }
}
