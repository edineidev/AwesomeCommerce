using Way2Commerce.Domain.Entities;
using Way2Commerce.Domain.Repositories;

namespace Way2Commerce.Data.SQLite.Repositories;

public class ProductRepository : IProductRepository
{
    public Product Create(Product product)
    {
        var db = new ProductingContext();

        db.Add(product);
        db.SaveChanges();

        return product;
    }

    public bool Delete(int productId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> List()
    {
        var db = new ProductingContext();

        return db.Products;
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }
}