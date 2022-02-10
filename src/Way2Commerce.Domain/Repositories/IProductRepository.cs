using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Domain.Repositories;

public interface IProductRepository
{
    Product Create(Product product);
    Product Get(int idProduct);
    IEnumerable<Product> List();
    Product Update(Product product);
    void Delete(int productId);
}