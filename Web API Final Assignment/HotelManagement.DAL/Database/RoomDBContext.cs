using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Database
{
    public class RoomDBContext : DbContext
    {
        public RoomDBContext() { }

        public DbSet<Room> Rooms { get; set; }
    }
}
