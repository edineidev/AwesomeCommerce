using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Domain.Repositories;

public interface IProductRepository
{
    Product Create(Product product);
    IEnumerable<Product> List();
    Product Update(Product product);
    bool Delete(int productId);
}