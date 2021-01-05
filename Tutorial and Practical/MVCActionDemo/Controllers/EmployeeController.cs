using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }

        [HttpGet]
        public ActionResult Search()
        {
            var input = "Another Search Action";
            return Content(input);
        }
    }
}