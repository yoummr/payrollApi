// It should be in separte assebmly or project not here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployee.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfDependent { get; set; }
        public float TotalBenefitCost { get; set; }
        public int PerPayCheckBefore { get; set; }
        public float PerPayCheckAfter { get; set; }
    }
}
