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

        var orange = Product("Orange");
        orange.AddRating(5, "I love oranges");
        orange.AddRating(2);

        return new Product[]
        {
            orange,
            Product("XBox Series X"),
        };
    }
}
