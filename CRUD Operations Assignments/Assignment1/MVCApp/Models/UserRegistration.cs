using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class UserRegistration
    {
        public Users User { get; set; }

        public Addresses Address { get; set; }
    }
}