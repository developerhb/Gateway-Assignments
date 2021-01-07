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
    public class HotelManager : IHotelManager
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels().Where(h => h.IsActive == true).OrderBy(h => h.Name).ToList();
        }

        public bool AddHotel(Hotel hotel)
        {
            return _hotelRepository.AddHotel(hotel);
        }
    }
}
