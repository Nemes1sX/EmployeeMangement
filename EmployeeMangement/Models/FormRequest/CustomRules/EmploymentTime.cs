﻿using System.ComponentModel.DataAnnotations;
using System;

namespace EmployeeMangement.Models.FormRequest.CustomRules
{
    public class EmploymentTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (EmployeeRequest)validationContext.ObjectInstance;
            
            if (employee.EmploymentDate == null)
            {
                return new ValidationResult("Employent date is Required");
            }

            if (employee.EmploymentDate >= DateTime.Today)
            {
                return new ValidationResult("Employment date cannot be future date");
            }

            return (employee.EmploymentDate < new DateTime(2000, 01, 01))
                ? new ValidationResult("Employment date cannot be earlier than 2000")
                : ValidationResult.Success;
        }
    }
}
