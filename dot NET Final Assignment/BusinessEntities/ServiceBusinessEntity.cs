using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ServiceBusinessEntity
    {
        public int ID { get; set; }

        public Guid Number { get; set; }

        public int MechanicID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Time { get; set; }

        public bool IsActive { get; set; }
    }
}
