using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservations");

        builder.Property(r => r.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(r => r.CreatedTime)
            .IsRequired();

        builder.Property(r => r.ModifiedTime)
            .IsRequired(false);

        builder.Property(r => r.IsActive)
            .IsRequired()
            .HasDefaultValue(true);
            
        builder.Property(r => r.UserNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(r => r.UserName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(r => r.TripId)
            .IsRequired();

        builder.Property(r => r.ReservationDate)
            .IsRequired();

        builder.HasOne(r => r.Trip)
            .WithMany(t => t.Reservations)
            .HasForeignKey(r => r.TripId);
    }
}
