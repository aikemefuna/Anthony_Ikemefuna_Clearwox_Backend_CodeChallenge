using System.Collections.Generic;

namespace ClearwoxCodeChallenge.Domain.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
