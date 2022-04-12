// It should be in separte assebmly or project not here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployee.Models
{
    public class Employee
    {
        public Employee()
        {
            PerPayCheckBefore = 2000;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfDependent { get; set; }
        public float TotalBenefitCost {
            get 
            {
                float discount = 0.0f;
                if (Name.Trim().ToUpper().StartsWith("A"))
                {
                    discount = 10;
                }
                    int sum = 1000 + (500 * NumberOfDependent);
                return sum - (sum * discount/100);
            }
            set { }
           
        }
        public int PerPayCheckBefore { get; set; }
        public float PerPayCheckAfter 
        {
            get 
            {
                return PerPayCheckBefore - TotalBenefitCost / 26;
            }
            set { } 
        }
    }
}
