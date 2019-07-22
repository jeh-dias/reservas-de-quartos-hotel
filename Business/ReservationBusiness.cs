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

        private ReservationRepository _reservationRepository;

        public ReservationBusiness()
        {
            _reservationRepository = new ReservationRepository();
        }

        /// <summary>
        /// Chamada para o repositório realizar a inserção do objeto 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool Add(Reservation reservation)
        {
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
        private int GetPrice(Reservation reservation)
        {
            Price priceEnum = (Price)reservation.RoomType;
            return (int)priceEnum;
        }
        /// <summary>
        /// Cálculo do valor total da diária
        /// </summary>
        /// <param name="reservation"></param>
        private void CalculateTotalReservation(Reservation reservation)
        {
            double reservationTotal = (double)reservation.TotalDays * (double)GetPrice(reservation);

            if (reservation.TotalDays > 5)
            {
                reservation.Total -= CalculateDiscount(reservation);
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
        private double CalculateDiscount(Reservation reservation)
        {
            double reservationTotal = (double)reservation.TotalDays * (double)GetPrice(reservation);
            return reservationTotal * DESCONTO_DEZ_POR_CENTO;
        }
    }
}
