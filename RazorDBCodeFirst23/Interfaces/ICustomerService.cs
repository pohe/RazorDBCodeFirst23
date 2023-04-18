using RazorDBCodeFirst23.Models;

namespace RazorDBCodeFirst23.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync(string filter);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task AddCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(Customer customer);
        Task<Customer> GetCustomerByIdAsync(int id);

    }
}
