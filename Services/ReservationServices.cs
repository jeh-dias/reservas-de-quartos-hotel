using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Reservation : IReservation
    {
        private const double DESCONTO_DEZ_POR_CENTO = 0.10;

        public void MakeReservation(ReservationDomain reservation)
        {
            int amountDaysOfReservation = reservation.GetAmountDays().Days;

            //saber resultado da reserva => valor do quarto * quantidade de dias 

            if (reservation.GetAmountDays().Days > 5)
            {
                GetDiscount(reservation);
            }
        }

        public void GetDiscount(ReservationDomain reservation)
        {
            double discount = 0;
            discount = reservation.GetTotal() * DESCONTO_DEZ_POR_CENTO;
            reservation.SetTotal(discount) ; 
        }
    }
}
