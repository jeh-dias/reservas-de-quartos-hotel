using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IReport
    {
        void MakeReport(List<Room> rooms);
    }
}
