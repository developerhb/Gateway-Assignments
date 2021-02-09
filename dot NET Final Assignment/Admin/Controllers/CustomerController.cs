using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _customerManager.GetCustomers();
            return View(customers);
        }
    }
}