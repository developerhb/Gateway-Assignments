using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("This is Student WebApi Get Request");
        }
    }
}
