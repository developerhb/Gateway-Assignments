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
    public class RoomManager : IRoomManager
    {
        private IRoomRepository _roomRepository;
        private IBookingRepository _bookingRepository;

        public RoomManager(IRoomRepository roomRepository, IBookingRepository bookingRepository)
        {
            _roomRepository = roomRepository;
            _bookingRepository = bookingRepository;
        }

        public List<Room> GetRooms(string type,string name)
        {
            var rooms = _roomRepository.GetRooms().OrderBy(h => h.Price);
            if (type == null && name == null)
                return rooms.ToList();
            else if (type != null && name != null)
            {
                if (type.Equals("city"))
                    return rooms.Where(r => r.Hotel.City.Equals(name)).ToList();
                else if (type.Equals("pin"))
                    return rooms.Where(r => r.Hotel.PinCode.Equals(name)).ToList();
                else if (type.Equals("price"))
                    return rooms.Where(r => r.Price.ToString().Equals(name)).ToList();
                else if (type.Equals("category"))
                    return rooms.Where(r => r.Category.Equals("name")).ToList();
                else
                    return null;
            }
            else
                return null;
                
        }

        public bool IsRoomAvailable(string date)
        {
            if(date != null)
            {
                var rooms = _roomRepository.GetRooms();
                var rooms_booked = _bookingRepository.GetBookings().Where(b => b.Date.Equals(date));
                if (rooms.Count() > rooms_booked.Count())
                    return true;
                return false;
            }
            return false;
        }

        public bool AddRoom(Room room)
        {
            return _roomRepository.AddRoom(room);
        }
    }
}
