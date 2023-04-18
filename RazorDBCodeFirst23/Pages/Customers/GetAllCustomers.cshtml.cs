using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDBCodeFirst23.Interfaces;
using RazorDBCodeFirst23.Models;

namespace RazorDBCodeFirst23.Pages.Customers
{
    public class GetAllCustomersModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public string CookieValue { get; set; }
        public IEnumerable<Customer> Customers { get; private set; }

        ICustomerService customerService;
        public GetAllCustomersModel(ICustomerService cService)
        {
            this.customerService = cService;
            Customers = new List<Customer>();
        }
        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(FilterCriteria))
            {
                Customers = await customerService.GetCustomersAsync();
            }
            else
                Customers = await customerService.GetCustomersAsync(FilterCriteria);
        }

    }
}
