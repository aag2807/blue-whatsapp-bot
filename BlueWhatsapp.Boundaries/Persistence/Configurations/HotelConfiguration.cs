using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    /// <summary>
    /// Configures the Hotel entity and seeds initial data
    /// </summary>
    /// <param name="builder">Entity type builder for Hotel</param>
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.ToTable("Hotels");
        
        builder.Property(h => h.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
            
        builder.Property(h => h.CreatedTime)
            .IsRequired();
            
        builder.Property(h => h.ModifiedTime)
            .IsRequired(false);
            
        builder.Property(h => h.IsActive)
            .IsRequired()
            .HasDefaultValue(true);
        
        builder.Property(h => h.Name)
            .IsRequired()
            .HasMaxLength(100);
                
        builder.Property(h => h.Price)
            .IsRequired()
            .HasColumnType("real");
                
        builder.Property(h => h.TravelType)
            .IsRequired()
            .HasMaxLength(50);
                
        builder.Property(h => h.Currency)
            .IsRequired()
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(h => h.MeetingPoint)
            .IsRequired()
            .HasMaxLength(50);
            
        builder.Property(h => h.Route)
            .IsRequired()
            .HasMaxLength(20);
        
        builder.HasMany(h => h.Schedules)
            .WithMany()
            .UsingEntity<HotelSchedule>(
                j => j.HasOne(hs => hs.Schedule)
                    .WithMany(s => s.HotelSchedules)
                    .HasForeignKey(hs => hs.ScheduleId),
                j => j.HasOne(hs => hs.Hotel)
                    .WithMany(h => h.HotelSchedules)
                    .HasForeignKey(hs => hs.HotelId)
            );

        // Create date time for all records
        var currentTime = DateTime.UtcNow;

        builder.HasData(
            new Hotel
            {
                Id = 1,
                Name = "SECRET CAP CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
                CreatedTime = currentTime,
                IsActive = true,
            },
            new Hotel
            {
                Id = 2,
                Name = "HYATT ZILARA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 3,
                Name = "HYATT ZIVA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 4,
                Name = "SPORTS ILLUSTRATED",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 5,
                Name = "TRS CAP CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 6,
                Name = "WESTIN PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA B",
                RouteId = 2,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 7,
                Name = "FOUR POINTS",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA B",
                RouteId = 2,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 8,
                Name = "DREAMS FLORA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 9,
                Name = "JEWEL PALM BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 10,
                Name = "SUNSCAPE COCO PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 11,
                Name = "SERENADE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 12,
                Name = "CATALONIA BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 13,
                Name = "CATALONIA ROYAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 14,
                Name = "RIU REPUBLICA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 15,
                Name = "BAHIA PRINCIPE (BARRERA)",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 16,
                Name = "RIU PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 17,
                Name = "RIU BAMBU",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 18,
                Name = "RIU MACAO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 19,
                Name = "RIU BAVARO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 20,
                Name = "HARD ROCK",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = "LOBBY DE GRUPOS",
                Currency = "USD",
                RouteId = 4,
                Route = "RUTA D",
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 21,
                Name = "OCCIDENTAL CARIBE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 22,
                Name = "ROYALTON PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 23,
                Name = "MAJESTIC COLONIAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 24,
                Name = "MAJESTIC ELEGANCE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 25,
                Name = "MAJESTIC MIRAGE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 26,
                Name = "ROYALTON BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 27,
                Name = "IBEROSTAR PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 28,
                Name = "IBEROSTAR DOMINICANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 29,
                Name = "IBEROSTAR SELECTION BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 30,
                Name = "IBEROSTAR BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 31,
                Name = "VISTA SOL PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 32,
                Name = "WHALA BAVARO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 33,
                Name = "SECRETS ROYAL BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 34,
                Name = "DREAMS ROYAL BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 35,
                Name = "DREAMS ROYAL BEACH (PREFERRED)",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 36,
                Name = "IMPRESSIVE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 37,
                Name = "MELIA CARIBE BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 38,
                Name = "MELIA CARIBE TROPICAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 39,
                Name = "MELIA PUNTA CANA BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 40,
                Name = "PARADISUS PALMA REAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 41,
                Name = "LOPESAN COSTA BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 42,
                Name = "BARCELO BAVARO BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 43,
                Name = "BARCELO BAVARO PALACE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 44,
                Name = "PUNTA CANA PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 45,
                Name = "VIK ARENA BLANCA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 46,
                Name = "OCEAN BLUE AND SAND",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 47,
                Name = "CARIBE DELUXE PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 48,
                Name = "TROPICAL DELUXE PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 49,
                Name = "BAVARO PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 50,
                Name = "OCCIDENTAL PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 51,
                Name = "GRAND BAVARO PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 52,
                Name = "GRAND PALLADIUM BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 53,
                Name = "GRAND PALLADIUM PALACE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 54,
                Name = "GRAND PALLADIUM PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 55,
                Name = "GRAND PALLADIUM TRS TURQUESA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 56,
                Name = "ZOETRY AGUA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 57,
                Name = "EXCELLENCE PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 58,
                Name = "SIRENIS",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 59,
                Name = "SECRETS TIDES PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 60,
                Name = "BREATHLESS PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 61,
                Name = "DREAMS ONYX PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 62,
                Name = "JEWEL PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 63,
                Name = "ROYALTON CHIC",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 64,
                Name = "NICKELODEON",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 65,
                Name = "OCEAN EL FARO",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            },
            new Hotel
            {
                Id = 66,
                Name = "DREAMS MACAO",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
                CreatedTime = currentTime,
                IsActive = true
            }
        );
    }
}