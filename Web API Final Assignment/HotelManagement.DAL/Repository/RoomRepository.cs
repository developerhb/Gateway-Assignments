using HotelManagement.DAL.Database;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Room> GetRooms()
        {
            return db.Rooms;
        }

        public bool AddRoom(Room room)
        {
            db.Rooms.Add(room);
            return db.SaveChanges() > 0;
        }
    }
}
