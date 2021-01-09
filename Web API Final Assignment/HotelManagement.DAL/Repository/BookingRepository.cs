using HotelManagement.DAL.Database;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Booking> GetBookings()
        {
            return db.Bookings;
        }

        public Booking FindBooking(int id)
        {
            return db.Bookings.Find(id);
        }

        public bool BookRoom(Booking booking)
        {
            db.Bookings.Add(booking);
            return db.SaveChanges() > 0;
        }

        public bool UpdateBooking(Booking booking)
        {
            db.Entry(booking).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
