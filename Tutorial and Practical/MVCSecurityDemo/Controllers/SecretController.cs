using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSecurityDemo.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        // GET: Secret
        public ActionResult Secret()
        {
            return Content("This is secret page");
        }

        [AllowAnonymous]
        public ActionResult Public()
        {
            return Content("This is public page");
        }
    }
}