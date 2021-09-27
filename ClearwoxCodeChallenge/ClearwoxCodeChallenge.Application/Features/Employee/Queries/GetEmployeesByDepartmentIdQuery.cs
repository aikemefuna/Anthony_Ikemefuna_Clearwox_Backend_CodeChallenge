using ClearwoxCodeChallenge.Application.Constants;
using ClearwoxCodeChallenge.Application.DTOs;
using ClearwoxCodeChallenge.Application.Interfaces.Repositories;
using ClearwoxCodeChallenge.Application.Wrappers;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Application.Features.Employee.Queries
{
    public class GetAllEmployeeByDepartmentIdQuery : IRequest<Response<List<EmployeeDTO>>>
    {
        [Required]
        public int DepartmentId { get; set; }
    }
    public class GetAllEmployeeByDepartmentIdQueryHandler : IRequestHandler<GetAllEmployeeByDepartmentIdQuery, Response<List<EmployeeDTO>>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllEmployeeByDepartmentIdQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<Response<List<EmployeeDTO>>> Handle(GetAllEmployeeByDepartmentIdQuery request, CancellationToken cancellationToken)
        {
            await Task.Delay(2);
            var employees = _employeeRepository
                .GetAll()
                .Select(c => new EmployeeDTO
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Address = c.Address,
                    DepartmentId = c.DepartmentId,
                    EmployeeId = c.EmployeeId,
                    JobTitle = c.JobTitle
                }).ToList();
            return ApplicationConstants.SuccessMessage<List<EmployeeDTO>>(employees, "success");

        }
    }
}
