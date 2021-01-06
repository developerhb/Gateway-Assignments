using HotelManagement.DAL.Database;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private HotelDBContext db = new HotelDBContext();

        public IQueryable<Hotel> GetAllHotels()
        {
            return db.Hotels;
        }

        public bool AddHotel(Hotel hotel)
        {
            db.Hotels.Add(hotel);
            return db.SaveChanges() > 0;
        }
    }
}
