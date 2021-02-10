using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.HttpAggregator.Util;
using Web.HttpAggregator.CustomerAttribute;

namespace Web.HttpAggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        [RateLimiter(Name = "Limit Request", Seconds = 2)]
        public async Task<List<string>> Get()
        {
            var mechanics = await HttpCall.GetRequest<List<string>>("http://localhost:51664/Dropdown/GetMechanics");
            var services = await HttpCall.GetRequest<List<string>>("http://localhost:51664/Dropdown/GetServices");
            mechanics.AddRange(services);
            return mechanics;
        }
    }
}
