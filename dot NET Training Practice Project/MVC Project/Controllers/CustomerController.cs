using Business.Interface;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerManager _customerManager;

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

        // GET: Customer/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerBusinessEntity businessEntity)
        {
            _customerManager.AddCustomer(businessEntity);
            return RedirectToAction("Index");
        }
    }
}