using Microsoft.AspNetCore.Mvc;
using Way2Commerce.Domain.Entities;

namespace Way2Commerce.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return new List<Product>(){
            new Product(1, "123456", "Wayne Batman", "Sou foda!!!", 99.99m, 1),
            new Product(2, "123457", "Wayne Batman2", "Sou foda2!!!", 999.99m, 1)
        };
    }
}
