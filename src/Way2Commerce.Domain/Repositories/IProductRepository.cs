using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Domain.Repositories;

public interface IProductRepository
{
    int Create(Product product);
}