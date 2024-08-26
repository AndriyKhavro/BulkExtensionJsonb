using BulkExtensionJsonb;
using EFCore.BulkExtensions;


int id = Random.Shared.Next();

var context = new ProductContext();
await context.Products.AddAsync(new Product { Id = id });
await context.SaveChangesAsync();

var product = await context.Products.FindAsync(id);

product!.UpdatedAt = DateTimeOffset.UtcNow;
await context.BulkUpdateAsync(new[] { product });