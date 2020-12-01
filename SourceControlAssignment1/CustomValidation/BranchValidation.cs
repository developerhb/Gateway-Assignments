using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SourceControlAssignment1.CustomValidation
{
    public class BranchValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            string[] validBranches = { "Computer", "Mechanical", "Electrical", "IT"};
            return validBranches.Contains(value);
        }
    }
}