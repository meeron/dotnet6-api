namespace WebApplicationNet60.Products;

using Microsoft.AspNetCore.Mvc;
using WebApplicationNet60.Products.Models;
using WebApplicationNet60.Products.Services;

[Route("products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet("")]
    public async Task<IReadOnlyList<Product>> GetProducts() =>
        await _productsService.Get();
}
