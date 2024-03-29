﻿using EmployeeMangement.DataContext;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EmployeeMangement.Models.FormRequest.CustomRules
{
    public class MaxLocationQuota : ValidationAttribute
    {    
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employeeRequest = (EmployeeRequest)validationContext.ObjectInstance;
            var _db = (EmployeeContext)validationContext.GetService(typeof(EmployeeContext));

            var location = _db.Locations.Find(employeeRequest.LocationId);

            if (location == null)
                return new ValidationResult("Location isn't existed");

            var employeeCount = _db.Entry(location).Collection(e => e.Employees).Query().Count();


            return employeeCount >= location.MaxAllocation
                ? new ValidationResult("Max quota of employees in location is reached")
                : ValidationResult.Success;
        }
    }
}
