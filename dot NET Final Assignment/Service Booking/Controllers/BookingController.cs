using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Service_Booking.Controllers
{
    public class BookingController : Controller
    {
        private IServiceManager _serviceManager;
        private IMechnicManager _mechanicManager;

        public BookingController(IServiceManager serviceManager,IMechnicManager mechanicManager)
        {
            _serviceManager = serviceManager;
            _mechanicManager = mechanicManager;
        }

        public ActionResult Book()
        {
            var mechanic = _mechanicManager.GetMechanics().First();
            var service = _mechanicManager.GetServices(mechanic).First();
            _serviceManager.BookService(service);
            return RedirectToAction("Index","Vehicle");
        }
    }
}