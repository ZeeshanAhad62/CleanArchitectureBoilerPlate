using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.Infrastructure.Repositories
{
    internal class CustomerRepository : ICustomerRepository 
    {
        private readonly CleanArchitectureDbContext _dbContext;
        public CustomerRepository(CleanArchitectureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Customer> AddCustomer(Customer input)
        {
            await _dbContext.Customers.AddAsync(input);

            await _dbContext.SaveChangesAsync();

            return input;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _dbContext.Customers.ToListAsync();

        }
    }
}
