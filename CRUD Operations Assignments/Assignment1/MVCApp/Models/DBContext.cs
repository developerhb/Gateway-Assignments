using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class DBContext : DbContext
    {
        public DBContext() { }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}