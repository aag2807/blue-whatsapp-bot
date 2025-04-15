using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class ConversationStateConfiguration : IEntityTypeConfiguration<ConversationState>
{
    public void Configure(EntityTypeBuilder<ConversationState> builder)
    {
        builder.ToTable("ConversationState");
        
        builder.Property(cs => cs.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder.Property(cs => cs.CreatedTime)
            .IsRequired();
            
        builder.Property(cs => cs.ModifiedTime)
            .IsRequired(false);
            
        builder.Property(cs => cs.IsActive)
            .IsRequired()
            .HasDefaultValue(true);
        
        builder.Property(cs => cs.CurrentStep)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(cs => cs.Flow)
            .HasConversion<int>()
            .IsRequired();

        builder.HasIndex(cs => cs.UserNumber);
    }
}