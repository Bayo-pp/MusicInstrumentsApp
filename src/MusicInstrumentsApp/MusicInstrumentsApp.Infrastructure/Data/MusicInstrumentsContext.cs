using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicInstrumentsApp.Domain.Entities;
using MusicInstrumentsApp.Infrastructure.EntityConfigurations;

namespace MusicInstrumentsApp.Infrastructure.Data;
public class MusicInstrumentsContext : IdentityDbContext
{
    public MusicInstrumentsContext(DbContextOptions<MusicInstrumentsContext> options)
        : base(options)
    {
    }

    public DbSet<Instrument> Instruments { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new InstrumentEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ManufacturerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CommentEntityTypeConfiguration());

        // Тестові дані
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "String" },
            new Category { Id = 2, Name = "Keyboard" }
        );

        modelBuilder.Entity<Manufacturer>().HasData(
            new Manufacturer { Id = 1, Name = "Yamaha", Country = "Japan" },
            new Manufacturer { Id = 2, Name = "Fender", Country = "USA" }
        );

        modelBuilder.Entity<Instrument>().HasData(
            new Instrument { Id = 1, Name = "Yamaha Acoustic Guitar", Price = 299.99m, ReleaseYear = 2020, CategoryId = 1, ManufacturerId = 1 },
            new Instrument { Id = 2, Name = "Fender Stratocaster", Price = 699.99m, ReleaseYear = 2019, CategoryId = 1, ManufacturerId = 2 },
            new Instrument { Id = 3, Name = "Yamaha Digital Piano", Price = 499.99m, ReleaseYear = 2021, CategoryId = 2, ManufacturerId = 1 }
        );
    }
}