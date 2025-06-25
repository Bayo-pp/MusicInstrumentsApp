using Microsoft.EntityFrameworkCore;
using MusicInstrumentsApp.Domain.Entities;
using MusicInstrumentsApp.Infrastructure.EntityConfigurations;

namespace MusicInstrumentsApp.Infrastructure.Data;
public class MusicInstrumentsContext : DbContext
{
    public MusicInstrumentsContext(DbContextOptions<MusicInstrumentsContext> options)
        : base(options)
    {
    }

    public DbSet<Instrument> Instruments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InstrumentEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ManufacturerEntityTypeConfiguration());
    }
}