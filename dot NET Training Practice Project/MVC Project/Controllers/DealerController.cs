using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class DealerController : Controller
    {
        private IDealerManager _dealerManager;

        public DealerController(IDealerManager dealerManager)
        {
            _dealerManager = dealerManager;
        }

        // GET: Dealer
        public ActionResult Index()
        {
            var dealers = _dealerManager.GetDealers();
            return View(dealers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(DealerRegistration registration)
        {
            _dealerManager.AddDealer(registration);
            return RedirectToAction("Index");
        }
    }
}