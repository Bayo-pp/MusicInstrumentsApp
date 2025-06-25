using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicInstrumentsApp.Domain.Entities;

namespace MusicInstrumentsApp.Infrastructure.EntityConfigurations;
internal class InstrumentEntityTypeConfiguration : IEntityTypeConfiguration<Instrument>
{
    public void Configure(EntityTypeBuilder<Instrument> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Name).IsRequired().HasMaxLength(100);
        builder.Property(i => i.Price).IsRequired();
        builder.Property(i => i.ReleaseYear).IsRequired();
        builder.HasOne(i => i.Category).WithMany(c => c.Instruments).HasForeignKey("CategoryId");
        builder.HasOne(i => i.Manufacturer).WithMany(m => m.Instruments).HasForeignKey("ManufacturerId");
    }
}