using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class ServiceController : Controller
    {
        private IServiceManager _serviceManager;

        public ServiceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: Service
        public ActionResult Index(int? mechID)
        {
            var services = _serviceManager.GetServices().Where(x => x.MechanicID == mechID);
            return View(services);
        }

        public ActionResult Create(int mechID)
        {
            TempData["mech"] = mechID;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceBusinessEntity businessEntity)
        {
            businessEntity.Number = Guid.NewGuid();
            businessEntity.MechanicID = Convert.ToInt32(TempData["mech"]);
            businessEntity.IsActive = true;
            _serviceManager.AddService(businessEntity);
            return RedirectToAction("Index","Mechnic");
        }
    }
}