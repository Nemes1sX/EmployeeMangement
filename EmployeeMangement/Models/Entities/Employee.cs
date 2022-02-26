using EmployeeMangement.Models.FormRequest.CustomRules;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeMangement.Models.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime EmploymentDate { get; set; }
        [Required]
        public string HomeAddress { get; set; }
        [Required]
        public int Salary { get; set; }
        public int? BossId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required, MaxLocationQuota()]
        public int LocationId { get; set; }
        [ForeignKey("BossId")]
        public virtual Boss Boss { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }
    }
}
