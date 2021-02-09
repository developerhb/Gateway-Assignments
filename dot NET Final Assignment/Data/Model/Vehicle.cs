using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Vehicle
    {
        public int ID { get; set; }

        public Guid Number { get; set; }

        public int CustomerID { get; set; }

        public string LicensePlate { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string RegistrationDate { get; set; }

        public string ChessisNumber { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
