using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IReservation
    {
        void MakeReservation(ReservationDomain reservation);
    }
}
