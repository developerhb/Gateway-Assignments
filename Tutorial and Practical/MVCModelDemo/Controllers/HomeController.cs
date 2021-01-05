using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is Home Controller";
        }
    }
}