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
    public Product Create(Product product)
    {
        return _productRepository.Create(product);
    }

    [HttpGet(Name = "ListProduct")]
    public IEnumerable<Product> List()
    {
        //return _productRepository.List();
        return new List<Product>(){
            new Product(1, "Code123", "Wayne Batman", "Sou foda!!!", 99.99m, 1)
        };
    }
}