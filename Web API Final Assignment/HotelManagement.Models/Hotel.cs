using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    [Table("Hotels")]
    public class Hotel
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        [Required]
        public string Address { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(12)]
        [Required]
        public string PinCode { get; set; }

        [Phone]
        [Required]
        public string ContactNumber { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        public string Website { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        [Required]
        public bool IsActive { get; set; }

        // 05/01/2021
        [StringLength(10)]
        [Required]
        public string CreatedDate { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        //05/01/2021
        [StringLength(10)]
        [Required]
        public string UpdatedDate { get; set; }

        [Required]
        public int UpdatedBy { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
