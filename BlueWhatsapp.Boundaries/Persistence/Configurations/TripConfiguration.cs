using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
            
        builder.Property(t => t.TripName)
            .IsRequired();

        builder.Property(t => t.RouteId)
            .IsRequired();

        builder.Property(t => t.IsActiveForToday)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(t => t.MaxCapacity)
            .IsRequired()
            .HasDefaultValue(30);
            
        // Configure relationships
        builder.HasOne(t => t.Route);

        builder.HasMany(t => t.Reservations)
            .WithOne(r => r.Trip)
            .HasForeignKey(r => r.TripId);
            
        var currentTime = DateTime.UtcNow;
        
        builder.HasData(
            new Trip()
            {
                Id = 1,
                TripName = "Ruta A (Recogida 1)",
                IsActive = true,
                RouteId = 1,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 2,
                TripName = "Ruta A (Recogida 2)",
                IsActive = true,
                RouteId = 1,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 3,
                TripName = "Ruta B (Recogida 1)",
                IsActive = true,
                RouteId = 2,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 4,
                TripName = "Ruta B (Recogida 2)",
                IsActive = true,
                RouteId = 2,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 5,
                TripName = "Ruta C (Recogida 1)",
                IsActive = true,
                RouteId = 3,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 6,
                TripName = "Ruta C (Recogida 2)",
                IsActive = true,
                RouteId = 3,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 7,
                TripName = "Ruta D (Recogida 1)",
                IsActive = true,
                RouteId = 4,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 8,
                TripName = "Ruta D (Recogida 2)",
                IsActive = true,
                RouteId = 4,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 9,
                TripName = "Ruta D (Recogida 3)",
                IsActive = true,
                RouteId = 4,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 10,
                TripName = "Ruta E1 (Recogida 1)",
                IsActive = true,
                RouteId = 5,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 11,
                TripName = "Ruta E1 (Recogida 2)",
                IsActive = true,
                RouteId = 5,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 12,
                TripName = "Ruta E1 (Recogida 3)",
                IsActive = true,
                RouteId = 5,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 13,
                TripName = "Ruta E2 (Recogida 1)",
                IsActive = true,
                RouteId = 6,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 14,
                TripName = "Ruta E2 (Recogida 2)",
                IsActive = true,
                RouteId = 6,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 15,
                TripName = "Ruta E2 (Recogida 3)",
                IsActive = true,
                RouteId = 6,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 16,
                TripName = "Ruta F (Recogida 1)",
                IsActive = true,
                RouteId = 7,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 17,
                TripName = "Ruta F (Recogida 2)",
                IsActive = true,
                RouteId = 7,
                IsActiveForToday = true,
                MaxCapacity = 30,
                CreatedTime = currentTime
            },
            new Trip()
            {
                Id = 18,
                TripName = "Externo",
                IsActive = true,
                RouteId = 8,
                IsActiveForToday = true,
                MaxCapacity = 100,
                CreatedTime = currentTime
            }
        );
    }
}