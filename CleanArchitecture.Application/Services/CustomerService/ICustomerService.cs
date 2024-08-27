using CleanArchitecture.Application.Services.CustomerService.Dtos;

namespace CleanArchitecture.Application.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<CustomerDto> AddCustomer(CustomerRequestDto input);

        Task<List<CustomerDto>> GetCustomers();
    }
}
