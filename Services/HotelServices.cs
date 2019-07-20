﻿using System;
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

        public void AddRooms(Room room)
        {
            //_room.AddRooms(room);
        }

        public void MakeAmountAvailableRooms(int amount, RoomType roomType)
        {
            //_room.AddAmountAvailableRoomsByType(amount, roomType);
        }

        public void MakeLocked(int amount, RoomType roomType)
        {
            //_locked.MakeLock(amount, roomType);
        }

        public void MakeUnlocked(int amount, RoomType roomType)
        {
            //_unlock.MakeUnLock(amount, roomType, rooms);
        }

        public void MakeReservation()
        {
            //reservation.MakeReservation();
        }

        public void MakeReport()
        {
            //_report.MakeReport(rooms);
        }

        public void ListRooms()
        {
            //_room.ListAllRooms(rooms);
        }
    }
}
