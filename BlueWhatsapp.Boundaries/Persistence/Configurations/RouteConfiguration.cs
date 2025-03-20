using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;


public class RouteConfiguration : IEntityTypeConfiguration<Route>
{
    /// <summary>
    /// Configures the Route entity and seeds initial data
    /// </summary>
    /// <param name="builder">Entity type builder for Route</param>
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.ToTable("Routes");
        
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
        
        // Configure route-specific properties
        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(20);
                
        builder.Property(r => r.Description)
            .IsRequired(false)
            .HasMaxLength(255);

        // Define relationship with Hotel
        builder.HasMany(r => r.Hotels)
            .WithOne(h => h.RouteNavigation)
            .HasForeignKey(h => h.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
        
        var currentTime = DateTime.UtcNow;

        builder.HasData(
            new Route
            {
                Id = 1,
                Name = "RUTA A",
                Description = "Ruta Punta Cana (Cap Cana)",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 2,
                Name = "RUTA B",
                Description = "Ruta La Romana",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 3,
                Name = "RUTA C",
                Description = "Ruta Bávaro Sur",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 4,
                Name = "RUTA D",
                Description = "Ruta Bávaro Norte",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 5,
                Name = "RUTA E1",
                Description = "Ruta Bávaro Central - Grupo 1",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 6,
                Name = "RUTA E2",
                Description = "Ruta Bávaro Central - Grupo 2",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Route
            {
                Id = 7,
                Name = "RUTA F",
                Description = "Ruta Uvero Alto",
                CreatedTime = currentTime,
                IsActive = true
            }
        );
    }
}