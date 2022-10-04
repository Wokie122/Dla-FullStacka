using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/institution/{institutionId}/customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public ActionResult Post([FromRoute] int institutionId, [FromBody] CreateCustomersDto dto)
        {
            var newCustomerId = _customerService.Create(institutionId, dto);

            return Created($"api/institution/{institutionId}/customer/{newCustomerId}", null);
        }
    }
}
