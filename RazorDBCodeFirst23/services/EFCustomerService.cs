using Microsoft.EntityFrameworkCore;
using RazorDBCodeFirst23.Interfaces;
using RazorDBCodeFirst23.Models;

namespace RazorDBCodeFirst23.services
{
    public class EFCustomerService : ICustomerService
    {
        private List<Customer> customers;

        private SaleDbContext context;
        public EFCustomerService(SaleDbContext saleContext)
        {
            context = saleContext;
            customers = context.Customers.AsNoTracking().ToList();
        }

        public Task AddCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Customer>> GetCustomersAsync(string filter)
        {
            throw new NotImplementedException();
            
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await context.Customers.AsNoTracking().ToListAsync();
        }
        //implementer interfaces og de relevante metoder    

    }
}
