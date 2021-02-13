using OfficeOpenXml;
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

        public void DownloadExcel()
        {
            var customers = _customerManager.GetCustomers();
            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("Customer Report");

            Sheet.Cells["A1"].Value = "Name";
            Sheet.Cells["B1"].Value = "Email";
            Sheet.Cells["C1"].Value = "Address1";
            Sheet.Cells["D1"].Value = "Address2";
            Sheet.Cells["E1"].Value = "Mobile";
            Sheet.Cells["F1"].Value = "Note";

            int row = 2;
            foreach (var item in customers)
            {

                Sheet.Cells[string.Format("A{0}", row)].Value = item.Name;
                Sheet.Cells[string.Format("B{0}", row)].Value = item.Email;
                Sheet.Cells[string.Format("C{0}", row)].Value = item.Address1;
                Sheet.Cells[string.Format("D{0}", row)].Value = item.Address2;
                Sheet.Cells[string.Format("E{0}", row)].Value = item.Mobile;
                Sheet.Cells[string.Format("F{0}", row)].Value = item.Note;
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment: filename=" + "Report.xlsx");
            Response.BinaryWrite(Ep.GetAsByteArray());
            Response.End();
        }
    }
}