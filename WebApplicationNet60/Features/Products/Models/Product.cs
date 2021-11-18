namespace WebApplicationNet60.Products.Models;

public record Product(
    Guid Id,
    string Name,
    string Description,
    DateTime CreatedAtUtc,
    ICollection<Rating> Ratings)
{
    public string Slug => this.Slug();
    public double Rating => this.Rating();
}

public record Rating(
    Guid Id,
    int Score,
    string? Comment);

public static class Logic
{ 
    public static Product Product(string name, string? description = default) =>
        new(
            Guid.NewGuid(),
            name,
            description ?? string.Empty,
            DateTime.UtcNow,
            new List<Rating>());

    public static string Slug(this Product product) =>
        product.Name.ToLower().Replace(" ", "-");

    public static void AddRating(this Product product, int score, string? comment = default) =>
        product.Ratings.Add(new Rating(Guid.NewGuid(), score, comment));

    public static double Rating(this Product product) =>
        product.Ratings.Any() ? product.Ratings.Average(x => x.Score) : 0;
}
