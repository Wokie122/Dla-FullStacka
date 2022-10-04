using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/institution/{institutionId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployessService _employeesService;

        public EmployeesController(IEmployessService employessService)
        {
            _employeesService = employessService;
        }

        [HttpPost]
        public ActionResult Post([FromRoute] int institutionId, [FromBody] CreateEmployeesDto dto)
        {
            var newemployeesId = _employeesService.Create(institutionId, dto);

            return Created($"api/institution/{institutionId}/employees/{newemployeesId}", null);
        }

    }
}
