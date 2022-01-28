using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeMangement.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string HomeAddress { get; set; }  
        public int Salary { get; set; }
        public int BossId { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("BossId")]
        public Boss Boss { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
