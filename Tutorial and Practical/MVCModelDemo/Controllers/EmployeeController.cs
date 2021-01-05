using MVCModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDBContext db = new EmpDBContext();
        // GET: Employee
        [OutputCache(CacheProfile = "Cache10Min")]
        public ActionResult Index()
        {
            var employees = from e in db.Employees orderby e.ID select e;
            return View(employees);
        }

        // GET: Employee/Details/5
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        public ActionResult Details(int id)
        {
            var employee = db.Employees.SingleOrDefault(m => m.ID == id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Some error occured in POST Create Action");
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Single(m => m.ID == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var employee = db.Employees.Single(m => m.ID == id);
                if(TryUpdateModel(employee))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return Content("Some error occured in POST Edit Action");
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return Content("Delete id: " + id);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Some error occured in POST Delete Action");
            }
        }
    }
}
