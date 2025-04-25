using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class TripScheduleConfiguration : IEntityTypeConfiguration<TripSchedule>
{
    public void Configure(EntityTypeBuilder<TripSchedule> builder)
    {
        builder.ToTable("TripSchedules");

        // Configure primary key
        builder.HasKey(ts => new { ts.TripId, ts.ScheduleId });

        // Configure properties
        builder.Property(ts => ts.TripId)
            .IsRequired();

        builder.Property(ts => ts.ScheduleId)
            .IsRequired();

        builder.Property(ts => ts.CreatedTime)
            .IsRequired();

        builder.Property(ts => ts.ModifiedTime)
            .IsRequired(false);

        builder.Property(ts => ts.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        // Configure relationships
        builder.HasOne(ts => ts.Trip)
            .WithMany(t => t.TripSchedules)
            .HasForeignKey(ts => ts.TripId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ts => ts.Schedule)
            .WithMany()
            .HasForeignKey(ts => ts.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);

        // Create indexes
        builder.HasIndex(ts => ts.TripId);
        builder.HasIndex(ts => ts.ScheduleId);
    }
} 