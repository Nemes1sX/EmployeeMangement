using System;
using System.ComponentModel.DataAnnotations;
using EmployeeMangement.Models.FormRequest;

namespace EmployeeMangement.Models.FormRequest.CustomRules
{
    public class WorkAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employeeRequest = (EmployeeRequest)validationContext.ObjectInstance;

            if (employeeRequest.BirthDate == null)
            {
                return new ValidationResult("Date of Birth is required.");
            }

            var age = DateTime.Today.Year - employeeRequest.BirthDate.Year;

            return (age >= 18 && age <= 70)
                ? ValidationResult.Success
                : new ValidationResult("Employee age must be between 18 and 70");
        }
    }
}
