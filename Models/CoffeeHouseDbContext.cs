using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.Models
{
    public class CoffeeHouseDbContext :DbContext
    {
        public CoffeeHouseDbContext(DbContextOptions<CoffeeHouseDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderManager> Orders { get; set; }

    }
}
