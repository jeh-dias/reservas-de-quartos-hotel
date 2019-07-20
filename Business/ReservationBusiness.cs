using Business.Interfaces;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ReservationBusiness : IReservationBusiness
    {
        private const double DESCONTO_DEZ_POR_CENTO = 0.10;

        private ReservationRepository _reservationRepository;
        public ReservationBusiness()
        {
            _reservationRepository = new ReservationRepository();
        }
        public bool Add(Reservation reservation)
        {
            return _reservationRepository.Add(reservation);
        }

        public List<Reservation> GetList()
        {
            return _reservationRepository.GetList();
        }

        public void GetDiscount(Reservation reservation)
        {
            double discount = 0;
            discount = reservation.GetTotal() * DESCONTO_DEZ_POR_CENTO;
            reservation.SetTotal(discount);
        }

        //int amountDaysOfReservation = reservation.GetAmountDays().Days;
        //saber resultado da reserva => valor do quarto * quantidade de dias 
        //if (reservation.GetAmountDays().Days > 5)
        //{
        //    GetDiscount(reservation);
        //}
    }
}
