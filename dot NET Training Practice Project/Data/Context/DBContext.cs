using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext() { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public DbSet<Mechanic> Mechanics { get; set; }
    }
}
