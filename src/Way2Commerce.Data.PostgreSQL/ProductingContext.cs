using Microsoft.EntityFrameworkCore;

using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Data.PpostgreSQL;
public class ProductingContext : DbContext
{
    private readonly string _connectionString;

    public ProductingContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql(_connectionString);
}