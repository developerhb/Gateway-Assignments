using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class AddressController : Controller
    {
        DBContext db = new DBContext();
        // GET: Address
        public ActionResult Index(int? userID)
        {
            if (userID == null)
                return RedirectToAction("Index","User");
            var addresses = db.Addresses.Where(x => x.UserID == userID);
            return View(addresses);
        }

        [HttpGet]
        public ActionResult Create(int userID)
        {
            TempData["user"] = userID;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Address address)
        {
            address.UserID = Convert.ToInt32(TempData["user"]);
            db.Addresses.Add(address);
            db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
    }
}