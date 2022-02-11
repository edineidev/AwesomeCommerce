using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using Way2Commerce.Domain.Entities;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .Property(e => e.Category)
            .HasConversion(new EnumToStringConverter<Category>())
            .HasMaxLength(250)
            .IsUnicode(false);

        builder.HasQueryFilter(p => p.Active);
    }
}