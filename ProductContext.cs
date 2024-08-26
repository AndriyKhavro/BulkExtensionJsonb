using Microsoft.EntityFrameworkCore;

namespace BulkExtensionJsonb;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Review> Reviews { get; set; } = [];
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}

public class Review
{
    public string User { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
}


public class ProductContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("Server=localhost;Port=5432;Database=BulkExtensionJsonb;Username=postgres;Password=somepassword;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Product>()
            .OwnsMany(product => product.Reviews, builder => { builder.ToJson(); });
    }
}