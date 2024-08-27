using CleanArchitecture.Application.Services.CustomerService.Dtos;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;


namespace CleanArchitecture.Application.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {

            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> AddCustomer(CustomerRequestDto input)
        {
            var customer = new Customer()
            {
                Name = input.Name,
            };
            var data = await _customerRepository.AddCustomer(customer);

            var customerr = new CustomerDto()
            {
                Id = data.Id,
                Name = data.Name,
            };

            return customerr;
        }

        public async Task<List<CustomerDto>> GetCustomers()
        {
            var customers = await _customerRepository.GetCustomers();

            var result = new List<CustomerDto>();

            foreach (var customer in customers) 
            {
                var customerDto = new CustomerDto
                {
                    Id = customer.Id,
                    Name = customer.Name 
                };

                result.Add(customerDto);
            }

            return result;
        }
    }
}
