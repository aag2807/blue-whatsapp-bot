using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
        
        // String properties - all nullable according to migration
        builder.Property(cs => cs.UserNumber)
            .HasMaxLength(30)
            .IsRequired(false);
            
        builder.Property(cs => cs.ZoneId)
            .HasMaxLength(120)
            .IsRequired(false);

        builder.Property(cs => cs.HotelId)
            .HasMaxLength(120)
            .IsRequired(false);

        builder.Property(cs => cs.LanguageId)
            .HasMaxLength(120)
            .IsRequired(false);

        builder.Property(cs => cs.PickUpDate)
            .HasMaxLength(120)
            .IsRequired(false);

        builder.Property(cs => cs.FullName)
            .HasMaxLength(60)
            .IsRequired(false);

        builder.Property(cs => cs.RoomNumber)
            .HasMaxLength(60)
            .IsRequired(false);

        builder.Property(cs => cs.Email)
            .HasMaxLength(60)
            .IsRequired(false);
            
        builder.Property(cs => cs.ScheduleId)
            .HasMaxLength(120)
            .IsRequired(false);
            
        builder.Property(cs => cs.PersonName)
            .HasMaxLength(120)
            .IsRequired(false);
        
        // Enum properties
        builder.Property(cs => cs.CurrentStep)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(cs => cs.Flow)
            .HasConversion<int>()
            .IsRequired();
        
        // Boolean properties
        builder.Property(cs => cs.IsComplete)
            .IsRequired();
            
        builder.Property(cs => cs.IsAdminOverridden)
            .IsRequired();
        
        // Integer properties
        builder.Property(cs => cs.Adults)
            .IsRequired();

        builder.Property(cs => cs.Children)
            .IsRequired();

        builder.HasData(
            new ConversationState
            {
                Id = 1,
                UserNumber = "1234567890",
                CurrentStep = Core.Enums.ConversationStep.None,
                Flow = Core.Enums.ConversationFlowEnum.None,
                IsComplete = false,
                IsActive = true,
                CreatedTime = DateTime.UtcNow,
                ModifiedTime = DateTime.UtcNow,
                IsAdminOverridden = false,
                ZoneId = "1234567890",
                HotelId = "1234567890",
                LanguageId = "1234567890",
                PickUpDate = "2025-01-01",
                FullName = "John Doe",
                RoomNumber = "1234567890",
                Email = "john.doe@example.com",
                Adults = 2,
                Children = 0,
                ScheduleId = "1234567890",
                PersonName = "",
            }
        );
    }
}