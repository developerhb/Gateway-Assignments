using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Mechanic
    {
        public int ID { get; set; }

        public Guid Number { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
