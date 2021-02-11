using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class MechnicController : Controller
    {
        private IMechnicManager _mechanicManager;

        public MechnicController(IMechnicManager mechanicManager)
        {
            _mechanicManager = mechanicManager;
        }

        // GET: Mechnic
        public ActionResult Index()
        {
            var mechanics = _mechanicManager.GetMechanics();
            return View(mechanics);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MechanicBusinessEntity businessEntity)
        {
            businessEntity.Number = Guid.NewGuid();
            _mechanicManager.AddMechanic(businessEntity);
            return RedirectToAction("Index");
        }
    }
}