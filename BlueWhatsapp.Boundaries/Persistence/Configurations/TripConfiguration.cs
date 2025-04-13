using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class TripConfiguration : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder.ToTable("Trips");

        builder.Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(t => t.CreatedTime)
            .IsRequired();

        builder.Property(t => t.ModifiedTime)
            .IsRequired(false);

        builder.Property(t => t.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(t => t.UserNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(t => t.UserName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.TripTime)
            .IsRequired();

        builder.Property(t => t.RouteId)
            .IsRequired();

        builder.Property(t => t.IsActiveForToday)
            .IsRequired()
            .HasDefaultValue(true);

        builder.HasOne(t => t.Route);

        builder.HasMany(t => t.Reservations)
            .WithOne(r => r.Trip)
            .HasForeignKey(r => r.TripId);
    }
}
