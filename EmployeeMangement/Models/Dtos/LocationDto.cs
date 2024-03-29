﻿using System.Collections.Generic;

namespace EmployeeMangement.Models.Dtos
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MaxAllocation { get; set; }
        public virtual List<LocationEmployeeDto> Employees { get; set; }
    }
}
