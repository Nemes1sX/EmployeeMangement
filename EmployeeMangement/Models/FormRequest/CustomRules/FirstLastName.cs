using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models.FormRequest.CustomRules
{
    public class FirstLastName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employeeRequest = (EmployeeRequest)validationContext.ObjectInstance;

            return (employeeRequest.FirstName == employeeRequest.LastName)
                ? new ValidationResult("First and last name can't match")
                : ValidationResult.Success;
        }
    }
}
