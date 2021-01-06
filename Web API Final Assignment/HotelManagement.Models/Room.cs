using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    [Table("Rooms")]
    public class Room
    {
        public int ID { get; set; }

        public int HotelID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string CreatedDate { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public string UpdatedDate { get; set; }

        [Required]
        public int UpdatedBy { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
