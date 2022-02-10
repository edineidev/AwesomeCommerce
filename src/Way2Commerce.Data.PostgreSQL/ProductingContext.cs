using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Data.PostgreSQL;
public class ProductingContext : DbContext
{
    public ProductingContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<string>()
            .AreUnicode(false)
            .HaveMaxLength(500);
    }

    public DbSet<Product> Products { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(e => e.Category)
            .HasConversion(new EnumToStringConverter<Category>())
            .HasMaxLength(250)
            .IsUnicode(false);

        modelBuilder.Entity<Product>().HasQueryFilter(p => p.Active);
    }
}