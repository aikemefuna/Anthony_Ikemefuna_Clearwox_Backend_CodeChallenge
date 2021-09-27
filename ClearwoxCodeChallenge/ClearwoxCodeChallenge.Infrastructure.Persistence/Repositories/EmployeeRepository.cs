using ClearwoxCodeChallenge.Application.Interfaces.Repositories;
using ClearwoxCodeChallenge.Domain.Entities;
using ClearwoxCodeChallenge.Infrastructure.Persistence.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace ClearwoxCodeChallenge.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll() => _context.Employee.ToList();

        public IList<Employee> ListAll() => _context.Employee.ToList();
    }
}
