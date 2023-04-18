using System.ComponentModel.DataAnnotations;

namespace RazorDBCodeFirst23.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        public int? Age { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }

}
