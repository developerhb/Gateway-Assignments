﻿using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BAL.Interface
{
    public interface IRoomManager
    {
        List<Room> GetRooms(string type,string name);

        bool IsRoomAvailable(string date);

        bool AddRoom(Room room);
    }
}
