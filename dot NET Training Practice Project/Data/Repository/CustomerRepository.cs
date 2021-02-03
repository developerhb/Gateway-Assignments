using Data.Context;
using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CustomerRepository : ICustomerRespository
    {
        private DBContext db = new DBContext();

        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return db.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
