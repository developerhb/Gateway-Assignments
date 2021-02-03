using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Customers")]
    public class Customer
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "First name invalid")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Last name invalid")]
        public string LastName { get; set; }

        [StringLength(60)]
        [Required]
        [EmailAddress(ErrorMessage = "Email address invalid")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Not a valid phone number")]
        public string Contact { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
