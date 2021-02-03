using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class VehicleController : Controller
    {
        private IVehicleManager _vehicleManager;

        public VehicleController(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }

        // GET: Vehicle
        public ActionResult Index(int? custID)
        {
            var vehicles = _vehicleManager.GetVehicles(custID);
            return View(vehicles);
        }

        [HttpGet]
        public ActionResult Create(int custID)
        {
            return View();
        }
    }
}