using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class HotelServices
    {
        public readonly ILock _locked; 
        public readonly IUnLock _unlock;
        public readonly IReservation _reservation;
        public readonly IReport _report;
        public readonly IRoom _room;

        public HotelServices(IRoom room, ILock locked, IUnLock unlocked, IReservation reservation, IReport report)
        {
           _locked = locked;
           _unlock = unlocked;
           _reservation = reservation;
           _report = report;
            _room = room;
        }

        public HotelServices()
        {

        }

        public void MakeAmountRooms(int amount, RoomType roomType)
        {
            _room.AddAmountRoomsByType(amount, roomType);
        }

        public void MakeLocked()
        {
            //locked.MakeLock();
        }

        public void MakeUnlocked()
        {
            //unlock.MakeUnLock();
        }

        public void MakeReservation()
        {
            //reservation.MakeReservation();
        }

        public void MakeReport()
        {
            //report.MakeReport();
        }
    }
}
