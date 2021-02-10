using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MechanicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicController : ControllerBase
    {
        [HttpGet,Route("GetMechanics")]
        public List<string> Get()
        {
            List<string> mechanics = new List<string>();
            mechanics.Add("xyz");
            mechanics.Add("abc");
            return mechanics;
        }
    }
}
