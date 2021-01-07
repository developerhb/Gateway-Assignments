using HotelManagement.BAL.Interface;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace HotelManagement.WebAPI.Controllers
{
    public class HotelController : ApiController
    {
        private IHotelManager _hotelManager;

        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;
        }

        [ResponseType(typeof(List<Hotel>))]
        public IHttpActionResult Get()
        {
            List<Hotel> hotels = _hotelManager.GetAllHotels();
            if (hotels != null)
                return Ok(hotels);
            return NotFound();
        }

        public IHttpActionResult Post([FromBody]Hotel hotel)
        {
            if (_hotelManager.AddHotel(hotel))
                return Ok("Hotel added successfully");
            return InternalServerError();
        }
    }
}
