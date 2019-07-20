using Business.Interfaces;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ReservationService
    {

        private readonly IReservationBusiness _reservationBusiness;
        public ReservationService(IReservationBusiness reservationBusiness)
        {
            _reservationBusiness = reservationBusiness;
        }

        public List<Reservation> Insert(Reservation reservation)
        {
            _reservationBusiness.Add(reservation);

            return _reservationBusiness.GetList();
        }       
    }
}
