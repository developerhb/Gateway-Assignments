using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBContext : DbContext
    {
        public DBContext() : base("ServiceBooking") { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        
        public DbSet<Mechanic> Mechanics { get; set; }

        public DbSet<Service> Services { get; set; }
    }
}
