using Microsoft.AspNetCore.Mvc;

using Way2Commerce.Domain.Entities;
using Way2Commerce.Domain.Repositories;

namespace Way2Commerce.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
    {
        _logger = logger;
        _productRepository = productRepository;
    }

    [HttpPost(Name = "CreateProduct")]
    public Product Create(Product product) => _productRepository.Create(product);

    [HttpGet("{productId:int}", Name = "GetProduct")]
    public Product Get(int productId) => _productRepository.Get(productId);

    [HttpGet(Name = "ListProduct")]
    public IEnumerable<Product> List() => _productRepository.List();

    [HttpPut(Name = "UpdateProduct")]
    public Product Update(Product product)
    {
        return _productRepository.Update(product);
    }

    [HttpDelete("{productId:int}", Name = "DeleteProduct")]
    public void Delete(int productId) => _productRepository.Delete(productId);
}