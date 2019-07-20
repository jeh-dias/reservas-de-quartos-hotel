using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IReservationBusiness
    {
        bool Add(Reservation reservation);

        List<Reservation> GetList();
    }
}
