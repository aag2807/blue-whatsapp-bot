using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("Messages");
        
        builder.Property(m => m.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(m => m.Number)
            .IsRequired();
        
        builder.Property(hs => hs.CreatedTime)
            .IsRequired();

        builder.Property(hs => hs.ModifiedTime)
            .IsRequired(false);
        
        builder.Property(m => m.Body)
            .IsRequired();
        
        builder.Property(m => m.From)
            .IsRequired();
        
        builder.Property(m => m.Status)
            .HasConversion<int>()
            .IsRequired();
    }
}