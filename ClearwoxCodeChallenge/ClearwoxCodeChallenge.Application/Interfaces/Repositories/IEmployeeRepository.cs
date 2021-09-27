using ClearwoxCodeChallenge.Domain.Entities;
using System.Collections.Generic;

namespace ClearwoxCodeChallenge.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();

    }
}
