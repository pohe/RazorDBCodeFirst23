using Microsoft.EntityFrameworkCore;

namespace RazorDBCodeFirst23.Models
{
    public class SaleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SaleDB23;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }

}
