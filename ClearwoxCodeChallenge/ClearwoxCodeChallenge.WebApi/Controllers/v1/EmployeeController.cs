using ClearwoxCodeChallenge.Application.Features.Employee.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.WebApi.Controllers.v1
{
    //[ApiVersion("1.0")]
    public class EmployeeController : BaseApiController
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllEmployeeQuery() { }));
        }

        // GET: api/<controller>/department/{departmentId}
        [HttpGet]
        [Route("department/{departmentId}")]
        public async Task<IActionResult> GetEmployeesByDepartmentId(int departmentId)
        {
            return Ok(await Mediator.Send(new GetAllEmployeeByDepartmentIdQuery() { DepartmentId = departmentId }));
        }
    }
}
