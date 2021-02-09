using Data.Model;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        DBContext db = new DBContext();

        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        public bool AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            return db.SaveChanges() > 0;
        }
    }
}
