using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL.Repository
{
    public interface IBookingRepository
    {
        IQueryable<Booking> GetBookings();

        Booking FindBooking(int id);

        bool BookRoom(Booking booking);

        bool UpdateBooking(Booking booking);
    }
}
