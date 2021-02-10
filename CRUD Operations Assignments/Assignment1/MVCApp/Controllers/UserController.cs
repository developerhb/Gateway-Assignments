using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class UserController : Controller
    {
        DBContext db = new DBContext();
        // GET: User
        public ActionResult Index()
        {
            var users = db.Users;
            return View(users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserRegistration registration)
        {
            var user = registration.User;
            var address = registration.Address;
            db.Users.Add(user);
            List<Addresses> addresses = new List<Addresses>();
            addresses.Add(address);
            user.Addresses = addresses;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}