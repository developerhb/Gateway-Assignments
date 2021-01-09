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
    public class BookingController : ApiController
    {
        private IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        public IHttpActionResult Post([FromBody]Booking booking)
        {
            if (_bookingManager.BookRoom(booking))
                return Ok("Room booked successfully");
            return InternalServerError();
        }

        [Route("api/booking/update/{type}/{id}")]
        public IHttpActionResult Put(string type,int id,[FromBody]string value)
        {
            if (_bookingManager.UpdateBooking(type, id, value))
                return Ok("Booking Updated Successfully");
            return InternalServerError();
        }
    }
}
