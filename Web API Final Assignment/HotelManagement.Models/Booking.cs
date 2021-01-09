using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    [Table("Bookings")]
    public class Booking
    {
        public int ID { get; set; }

        [Required]
        public int RoomID { get; set; }

        [Required]
        public string Date { get; set; }

        public string Status { get; set; }

        public virtual Room Room { get; set; }
    }
}
