using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet, Route("GetBookings")]
        public List<string> Get()
        {
            List<string> bookings = new List<string>();
            bookings.Add("xyz-Repairing");
            bookings.Add("abc-Cleaning");
            return bookings;
        }
    }
}
