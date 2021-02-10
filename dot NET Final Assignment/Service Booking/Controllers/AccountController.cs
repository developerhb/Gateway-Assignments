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
    public class AccountController : Controller
    {
        ICustomerManager _customerManager;

        public AccountController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            bool IsValid = _customerManager.GetCustomers().Any(x => x.Email.Equals(login.Email) && x.Password.Equals(login.Password));
            if(IsValid)
            {
                FormsAuthentication.SetAuthCookie(login.Email,false);
                Session["user"] = _customerManager.GetCustomers().Where(x => x.Email.Equals(login.Email) && x.Password.Equals(login.Password)).First().ID;
                return RedirectToAction("Index","Vehicle");
            }
            else
            {
                ModelState.AddModelError("","Incorrect Login ID or Password");
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CustomerBusinessEntity register)
        {
            register.Number = Guid.NewGuid();
            _customerManager.AddCustomer(register);
            return RedirectToAction("Login");

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}