using Microsoft.EntityFrameworkCore;

using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Data.PostgreSQL;
public class ProductingContext : DbContext
{
    public ProductingContext(DbContextOptions? options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql();
}