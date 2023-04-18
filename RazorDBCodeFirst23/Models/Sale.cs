using System.ComponentModel.DataAnnotations;

namespace RazorDBCodeFirst23.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductName { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime SalesDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }

}
