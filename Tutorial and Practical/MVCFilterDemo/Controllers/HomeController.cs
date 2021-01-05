using MVCFilterDemo.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilterDemo.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 15)]
        public string Index()
        {
            return "This is Home Controller";
        }

        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}