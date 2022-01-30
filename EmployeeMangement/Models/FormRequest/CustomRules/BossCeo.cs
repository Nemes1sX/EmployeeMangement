using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models.FormRequest.CustomRules
{
    public class BossCeo : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (EmployeeRequest)validationContext.ObjectInstance;

            return (employee.RoleId != 1 && employee.BossId != null)
                ? ValidationResult.Success
                : new ValidationResult("Boss can't have a CEO");
        }
    }
}
