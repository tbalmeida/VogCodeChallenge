using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Models.Entities;
using VogCodeChallenge.API.Repositories.Interfaces;

namespace VogCodeChallenge.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EmployeeVM> EmployeesByDepartment(int departmentId)
        {
            var ret = GetEmployees(departmentId);
            var models = new List<EmployeeVM>();
            foreach (var entity in ret)
            {
                models.Add(new EmployeeVM(entity));
            }

            return models;
        }

        public IEnumerable<Employee> GetAll()
        {
            var ret = GetEmployees();
            return ret;
        }

        public IList<Employee> ListAll()
        {
            var ret = GetEmployees();
            return ret;
        }

        private List<Employee> GetEmployees(int departmentId=0)
        {
            var query = _context.Employees
                .Include(emp => emp.Department)
                .Include(emp => emp.JobTitle)
                .AsQueryable();

            if (departmentId > 0)
            {
                query = query.Where(emp => emp.DepartmentId == departmentId);
            }

            var results = query.OrderBy(emp => emp.FirstName).ToList();
            return results;
        }
    }
}
