using Microsoft.EntityFrameworkCore;

namespace UITesting.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add a parameterless constructor
        public AppDbContext() : base()
        {
        }

        public virtual DbSet<Product> Products { get; set; } // Make Products property virtual
    }
}
