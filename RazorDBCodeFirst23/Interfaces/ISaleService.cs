using RazorDBCodeFirst23.Models;

namespace RazorDBCodeFirst23.Interfaces
{
    public interface ISaleService
    {
        Task<IEnumerable<Sale>> GetSalesAsync(int maxAmount);
        Task<IEnumerable<Sale>> GetSalesAsync();
        Task AddSaleAsync(Sale sale);
        Task DeleteSaleAsync(Sale sale);
        Task<Sale> GetSaleByIdAsync(int id);
        Task<Customer> GetSalesByCustomerIdAsync(int CustomerId);

    }
}
