﻿using HotelManagement.BAL.Interface;
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
    public class RoomController : ApiController
    {
        private IRoomManager _roomManager;

        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        [ResponseType(typeof(List<Room>))]
        [Route("api/room/search/{type?}/{name?}")]
        public IHttpActionResult Get(string type = null,string name = null)
        {
            var rooms = _roomManager.GetRooms(type,name);
            if (rooms == null)
                return InternalServerError();
            else if (rooms.Count == 0)
                return NotFound();
            else
                return Ok(rooms);
        }

        [Route("api/room/isavailable/{day}/{month}/{year}")]
        public IHttpActionResult Get(string day,string month,string year)
        {
            string date = day + "/" + month + "/" + year;
            return Ok(_roomManager.IsRoomAvailable(date));
        }

        public IHttpActionResult Post([FromBody]Room room)
        {
            if (_roomManager.AddRoom(room))
                return Ok("Room Added");
            return InternalServerError();
        }
    }
}
