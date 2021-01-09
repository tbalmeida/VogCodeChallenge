using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Models.Entities;
using VogCodeChallenge.API.Repositories.Interfaces;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult<EmployeeVM> GetAll()
        {
            try
            {
                var results = _employeeRepository.GetAll();

                var models = new List<EmployeeVM>();
                foreach (var entity in results)
                {
                    models.Add(new EmployeeVM(entity));
                }

                return Ok(models);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error on Employee.GetAll - { ex.Message }");
            }
        }

        [HttpGet("department/{departmentId}")]
        public ActionResult<List<EmployeeVM>> GetEmployeesByDepartment([FromRoute] int departmentId)
        {
            try
            {
                var results = _employeeRepository.EmployeesByDepartment(departmentId);
                return results;
            }
            catch (Exception ex)
            {
                return BadRequest($"Error on Employee.GetEmployeesByDepartment - { ex.Message }");
            }
        }
    }
}
