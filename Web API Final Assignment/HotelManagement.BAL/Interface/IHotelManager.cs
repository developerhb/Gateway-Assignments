using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BAL.Interface
{
    public interface IHotelManager
    {
        List<Hotel> GetAllHotels();

        bool AddHotel(Hotel hotel);
    }
}
