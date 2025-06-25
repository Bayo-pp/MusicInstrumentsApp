using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicInstrumentsApp.Domain.Entities;

namespace MusicInstrumentsApp.Infrastructure.EntityConfigurations;
internal class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Content).IsRequired().HasMaxLength(500);
        builder.Property(c => c.UserId).IsRequired();
        builder.Property(c => c.CreatedAt).IsRequired();
        builder.HasOne(c => c.Instrument).WithMany(i => i.Comments).HasForeignKey(c => c.InstrumentId);
    }
}