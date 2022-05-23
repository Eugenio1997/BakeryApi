using Microsoft.EntityFrameworkCore;

namespace BakeryApi.Data
{
    public class BakeryApiContext : DbContext
    {
        public BakeryApiContext (DbContextOptions<BakeryApiContext> options)
            : base(options)
        {
        }

        public DbSet<BakeryApi.Models.Client>? Client { get; set; }

        public DbSet<BakeryApi.Models.OrderItem>? OrderItem { get; set; }

        public DbSet<BakeryApi.Models.Order>? Order { get; set; }

        public DbSet<BakeryApi.Models.Product>? Product { get; set; }
    }
}
