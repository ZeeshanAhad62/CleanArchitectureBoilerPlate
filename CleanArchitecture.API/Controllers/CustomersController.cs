using CleanArchitecture.Application.Services.CustomerService;
using CleanArchitecture.Application.Services.CustomerService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerRequestDto input)
        {
            var customer = await _customerService.AddCustomer(input);

            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customer = await _customerService.GetCustomers();

            return Ok(customer);
        }
    }
}
