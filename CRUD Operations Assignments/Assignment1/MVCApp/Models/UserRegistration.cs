using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class UserRegistration
    {
        public User User { get; set; }

        public Address Address { get; set; }
    }
}