using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Address
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string Type { get; set; }

        [Display(Name = "Address")]
        public string Value { get; set; }

        public virtual User User { get; set; }
    }
}