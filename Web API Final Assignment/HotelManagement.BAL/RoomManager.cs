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

        public RoomManager(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public List<Room> GetRooms(string type,string name)
        {
            var rooms = _roomRepository.GetRooms().OrderBy(h => h.Price);
            if (type == null && name == null)
                return rooms.ToList();
            else if (type != null && name != null)
            {
                if (type.Equals("city"))
                    return rooms.Where(h => h.Hotel.City.Equals(name)).ToList();
                else if (type.Equals("pin"))
                    return rooms.Where(h => h.Hotel.PinCode.Equals(name)).ToList();
                else if (type.Equals("price"))
                    return rooms.Where(h => h.Price.ToString().Equals(name)).ToList();
                else if (type.Equals("category"))
                    return rooms.Where(h => h.Category.Equals("name")).ToList();
                else
                    return null;
            }
            else
                return null;
                
        }

        public bool AddRoom(Room room)
        {
            return _roomRepository.AddRoom(room);
        }
    }
}
