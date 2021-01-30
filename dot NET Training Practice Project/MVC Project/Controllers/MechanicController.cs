using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class MechanicController : Controller
    {
        private IMechanicManager _mechanicManager;

        public MechanicController(IMechanicManager mechanicManager)
        {
            _mechanicManager = mechanicManager;
        }

        // GET: Mechanic
        public ActionResult Index()
        {
            var mechanics = _mechanicManager.GetMechanics();
            return View(mechanics);
        }
    }
}