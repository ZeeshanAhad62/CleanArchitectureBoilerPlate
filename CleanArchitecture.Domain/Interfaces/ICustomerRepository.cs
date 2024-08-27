using CleanArchitecture.Domain.Models;


namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer input);
        Task<List<Customer>> GetCustomers();
    }
}
