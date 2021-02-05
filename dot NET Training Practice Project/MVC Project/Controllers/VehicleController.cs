using Business.Interface;
using BusinessEntities;
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
            TempData["custID"] = custID;
            return View();
        }

        [HttpPost]
        public ActionResult Create(VehicleBusinessEntity registration)
        {
            registration.CustomerID = Convert.ToInt32(TempData["custID"]);
            _vehicleManager.AddVehicle(registration);
            return RedirectToAction("Index");
        }
    }
}