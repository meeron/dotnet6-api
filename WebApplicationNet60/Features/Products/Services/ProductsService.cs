namespace WebApplicationNet60.Products.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationNet60.Products.Models;
using static WebApplicationNet60.Products.Models.Logic;

public interface IProductsService
{
    Task<IReadOnlyList<Product>> Get();
}

public class ProductsService : IProductsService
{
    public async Task<IReadOnlyList<Product>> Get()
    {
        await Task.CompletedTask;

        return new Product[]
        {
            Product("Orange"),
            Product("XBox Series X"),
        };
    }
}
