using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}