using SourceControlAssignment1.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SourceControlAssignment1.Models
{
    public class User
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public String Name { get; set; }

        [Range(18, 60)]
        [Required]
        public int Age { get; set; }

        [BranchValidation]
        [Required]
        public String Branch { get; set; }
    }
}