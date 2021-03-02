using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Passenger
    {
        public int ID { get; set; }

        public Guid Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }
    }

    public class DBContext : DbContext
    {
        public DBContext() { }

        public DbSet<Passenger> Passenger { get; set; }
    }
}