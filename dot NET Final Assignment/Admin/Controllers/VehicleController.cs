using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class VehicleController : Controller
    {
        private IVehicleManager _vehicleManager;

        public VehicleController(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }

        // GET: Vehicle
        public ActionResult Index(int? userID)
        {
            var vehicles = _vehicleManager.GetVehicles().Where(x => x.CustomerID == userID);
            return View(vehicles);
        }
    }
}