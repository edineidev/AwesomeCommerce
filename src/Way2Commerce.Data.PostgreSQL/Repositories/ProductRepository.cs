using Way2Commerce.Data.PpostgreSQL;
using Way2Commerce.Domain.Entities;
using Way2Commerce.Domain.Repositories;

namespace Way2Commerce.Data.PostgreSQL.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly string _connectionString;

    public ProductRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public Product Create(Product product)
    {
        var db = new ProductingContext(_connectionString);

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
        var db = new ProductingContext(_connectionString);

        return db.Products;
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }
}