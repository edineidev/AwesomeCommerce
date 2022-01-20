using Way2Commerce.Data.PostgreSQL;
using Way2Commerce.Domain.Entities;
using Way2Commerce.Domain.Repositories;

namespace Way2Commerce.Data.PostgreSQL.Repositories;

public class ProductRepository : IProductRepository
{
    private ProductingContext _productingContext;

    public ProductRepository(ProductingContext productingContext)
    {
        _productingContext = productingContext;
        
    }
    public Product Create(Product product)
    {
        _productingContext.Add(product);
        _productingContext.SaveChanges();

        return product;
    }

    public bool Delete(int productId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> List()
    {
        return _productingContext.Products;
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }
}