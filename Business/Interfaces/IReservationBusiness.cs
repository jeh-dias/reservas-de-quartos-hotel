using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface base para a classe de regra de negócio de uma reserva
    /// </summary>
    public interface IReservationBusiness
    {
        bool Add(Reservation reservation, List<Room> rooms);

        List<Reservation> GetList();
    }
}
