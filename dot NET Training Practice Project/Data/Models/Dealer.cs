using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Dealers")]
    public class Dealer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-z]*$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+([ '-][a-zA-Z]+)*$")]
        public string LastName { get; set; }

        [Required]
        [StringLength(60)]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Contact { get; set; }

        public virtual ICollection<Mechanic> Mechanics { get; set; }
    }
}
