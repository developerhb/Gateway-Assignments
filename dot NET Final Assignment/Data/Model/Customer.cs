using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Customer
    {
        public int ID { get; set; }

        public Guid Number { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Mobile { get; set; }

        public string Note { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
