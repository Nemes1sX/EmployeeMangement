using System;

namespace EmployeeMangement.Models.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Boss { get; set; }
        public string Role { get; set; }
        public string HomeAddress { get; set; }
        public int Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
