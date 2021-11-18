namespace WebApplicationNet60.Products.Models;

public record Product(
    Guid Id,
    string Name,
    string Description,
    DateTime CreatedAtUtc)
{
    public string Slug => this.Slug();
}

public static class Logic
{ 
    public static Product Product(string name, string? description = default) =>
        new(Guid.NewGuid(), name, description ?? string.Empty, DateTime.UtcNow);

    public static string Slug(this Product product) =>
        product.Name.ToLower().Replace(" ", "-");
}
