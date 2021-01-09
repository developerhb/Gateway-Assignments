using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BAL.Interface
{
    public interface IBookingManager
    {
        bool BookRoom(Booking booking);

        bool UpdateBooking(string type, int id, string value);
    }
}
