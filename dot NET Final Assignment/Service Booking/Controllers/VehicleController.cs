using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Service_Booking.Controllers
{
    public class VehicleController : Controller
    {
        private IVehicleManager _vehicleManager;

        public VehicleController(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }

        // GET: Vehicle
        public ActionResult Index()
        {
            int userID = Convert.ToInt32(Session["user"]);
            var vehicles = _vehicleManager.GetVehicles().Where(x => x.CustomerID == userID);
            return View(vehicles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleBusinessEntity vehicle)
        {
            int userID = Convert.ToInt32(Session["user"]);
            vehicle.CustomerID = userID;
            vehicle.Number = Guid.NewGuid();
            _vehicleManager.AddVehicle(vehicle);
            return RedirectToAction("Index");
        }

        public JsonResult Delete(int ID)
        {
            return Json(_vehicleManager.DeleteVehicle(ID),JsonRequestBehavior.AllowGet);
        }
    }
}