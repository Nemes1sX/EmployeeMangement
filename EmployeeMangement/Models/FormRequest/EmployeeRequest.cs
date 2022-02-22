using EmployeeMangement.Models.FormRequest.CustomRules;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models.FormRequest
{
    public class EmployeeRequest
    {
        [Required, MinLength(4), MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MinLength(4), MaxLength(50), FirstLastName]
        public string LastName { get; set; }
        [WorkAge]
        public DateTime BirthDate { get; set; }
        [EmploymentTime]
        public DateTime EmploymentDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Salary can't be negative")]
        public int Salary { get; set; }
        public int? BossId { get; set; }
        [Required, BossCeo]
        public int RoleId { get; set; }
    }
}
