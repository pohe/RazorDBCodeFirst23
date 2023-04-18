using RazorDBCodeFirst23.Interfaces;
using RazorDBCodeFirst23.Models;

namespace RazorDBCodeFirst23.services
{
    public class EFSaleService : ISaleService
    {
        private List<Sale> sales;
        private SaleDbContext context;
        public EFSaleService(SaleDbContext service)
        {
            context = service;
        }

        public Task AddSaleAsync(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSaleAsync(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetSaleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sale>> GetSalesAsync(int maxAmount)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sale>> GetSalesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetSalesByCustomerIdAsync(int CustomerId)
        {
            throw new NotImplementedException();
        }
        //implementer interfacet og de relevante metoder
    }

}
