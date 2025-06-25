using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicInstrumentsApp.Domain.Entities;

namespace MusicInstrumentsApp.Infrastructure.EntityConfigurations;
internal class ManufacturerEntityTypeConfiguration : IEntityTypeConfiguration<Manufacturer>
{
    public void Configure(EntityTypeBuilder<Manufacturer> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
        builder.Property(m => m.Country).IsRequired().HasMaxLength(50);
    }
}