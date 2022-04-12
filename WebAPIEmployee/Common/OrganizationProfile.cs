using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEmployee.DTO;
using WebAPIEmployee.Models;

namespace WebAPIEmployee.Common
{
    public class OrganizationProfile: Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
