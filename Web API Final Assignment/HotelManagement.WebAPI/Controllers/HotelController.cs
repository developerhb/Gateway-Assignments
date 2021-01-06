using HotelManagement.BAL.Interface;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManagement.WebAPI.Controllers
{
    public class HotelController : ApiController
    {
        private IHotelManager _hotelManager;

        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;
        }

        public List<Hotel> Get()
        {
            return _hotelManager.GetAllHotels();
        }

        public string Post([FromBody]Hotel hotel)
        {
            if (_hotelManager.AddHotel(hotel))
                return "Product Added";
            return "Not added";
        }
    }
}
