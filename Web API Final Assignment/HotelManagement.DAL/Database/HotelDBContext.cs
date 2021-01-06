using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Database
{
    public class HotelDBContext : DbContext
    {
        public HotelDBContext() { }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
