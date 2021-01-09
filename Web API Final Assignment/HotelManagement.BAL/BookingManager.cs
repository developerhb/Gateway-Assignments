using HotelManagement.BAL.Interface;
using HotelManagement.DAL.Repository;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BAL
{
    public class BookingManager : IBookingManager
    {
        private IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public bool BookRoom(Booking booking)
        {
            return _bookingRepository.BookRoom(booking);
        }

        public bool UpdateBooking(string type,int id,string value)
        {
            Booking booking = _bookingRepository.FindBooking(id);
            if (type.Equals("date"))
                booking.Date = value;
            else if (type.Equals("status"))
                booking.Status = value;
            return _bookingRepository.UpdateBooking(booking);
        }
    }
}
