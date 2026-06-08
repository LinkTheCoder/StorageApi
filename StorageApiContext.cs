using Microsoft.EntityFrameworkCore;
using StorageApi.Models;

public class StorageApiContext(DbContextOptions<StorageApiContext> options) : DbContext(options)
{
    public DbSet<Product> Product { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Hammare", Price = 149, Category = "Verktyg", Shelf = "A1", Count = 20, Description = "Standardhammare 500g" },
            new Product { Id = 2, Name = "Skruvmejsel", Price = 59, Category = "Verktyg", Shelf = "A2", Count = 35, Description = "Platt skruvmejsel 6mm" },
            new Product { Id = 3, Name = "Skiftnyckel", Price = 199, Category = "Verktyg", Shelf = "A3", Count = 15, Description = "Justerbar skiftnyckel 250mm" },
            new Product { Id = 4, Name = "Spackelputs", Price = 89, Category = "Bygg", Shelf = "B1", Count = 50, Description = "Spackelspade i rostfritt stål" },
            new Product { Id = 5, Name = "Målarpensel", Price = 39, Category = "Bygg", Shelf = "B2", Count = 100, Description = "Pensel 50mm för inomhusmålning" }
        );
    }
}
