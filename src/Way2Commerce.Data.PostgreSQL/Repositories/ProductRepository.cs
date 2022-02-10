using Microsoft.EntityFrameworkCore;

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
    
    public Product Get(int productId)
    {
        return _productingContext.Products.AsNoTracking().Single(p => p.Id == productId);
    }
    
    public IEnumerable<Product> List()
    {
        return _productingContext.Products.AsNoTracking();
    }

    public Product Update(Product productNewValues)
    {
        var actualProduct = this.Get(productNewValues.Id);

        actualProduct.PopuleValues(productNewValues);

        _productingContext.SaveChanges();

        return actualProduct;
    }

    public void Delete(int productId)
    {
        var product = _productingContext.Products.Single(p => p.Id == productId);

        product.SetDeactivate();

        _productingContext.SaveChanges();
    }
}