using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Repository
{
    public interface IRoomRepository
    {
        IQueryable<Room> GetRooms();

        bool AddRoom(Room room);
    }
}
