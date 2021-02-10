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
    public class ServiceContoller : ControllerBase
    {
        [HttpGet,Route("GetServices")]
        public List<string> Get()
        {
            List<string> services = new List<string>();
            services.Add("Repairing");
            services.Add("Cleaning");
            return services;
        }
    }
}
