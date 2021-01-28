using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class VehicleBusinessEntity
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        [Display(Name = "Number Plate")]
        public string NumberPlate { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }
    }
}
