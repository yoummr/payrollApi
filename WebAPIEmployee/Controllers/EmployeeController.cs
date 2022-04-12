using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEmployee.DTO;
using WebAPIEmployee.Models;

namespace WebAPIEmployee.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet("employee/all")]
        public ActionResult<List<EmployeeDto>> GetAll()
        {
            return _mapper.Map<List<EmployeeDto>>(_employeeRepository.GetAllEmployee().ToList()); 
        }


        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost("employee/Add")]
        public ActionResult<Employee> AddEmployee(EmployeeDto empDto)
        {
            var employee = new Employee { Name = empDto.Name, NumberOfDependent = empDto.NumberOfDependent };
            _employeeRepository.Add(employee);

            return employee;
        }
      }
}
