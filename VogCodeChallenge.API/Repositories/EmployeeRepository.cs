using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Employee> GetAll()
        {
            var ret = _context.Employees.OrderBy(e => e.FirstName).ToList();
            return ret;
        }

        public IList<Employee> ListAll()
        {
            var ret = _context.Employees.OrderBy(e => e.FirstName).ToList();
            return ret;
        }
    }
}
