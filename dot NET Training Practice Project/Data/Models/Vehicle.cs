using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        public string NumberPlate { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Za-z]+$")]
        public string Company { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Za-z ]+$")]
        public string Model { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
