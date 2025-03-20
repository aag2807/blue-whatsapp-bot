using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

/// <summary>
/// Configuration for the HotelSchedule entity
/// </summary>
public class HotelScheduleConfiguration : IEntityTypeConfiguration<HotelSchedule>
{
    public void Configure(EntityTypeBuilder<HotelSchedule> builder)
    {
        builder.ToTable("HotelSchedules");

        // Configure base entity properties
        builder.Property(hs => hs.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(hs => hs.CreatedTime)
            .IsRequired();

        builder.Property(hs => hs.ModifiedTime)
            .IsRequired(false);

        builder.Property(hs => hs.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        // Configure HotelSchedule-specific properties
        builder.Property(hs => hs.HotelId)
            .IsRequired();

        builder.Property(hs => hs.ScheduleId)
            .IsRequired();

        builder.Property(hs => hs.RecogidaNumber)
            .IsRequired();

        // Define relationships
        builder.HasOne(hs => hs.Hotel)
            .WithMany()
            .HasForeignKey(hs => hs.HotelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(hs => hs.Schedule)
            .WithMany()
            .HasForeignKey(hs => hs.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);

        // Create unique index to prevent duplicate hotel-schedule-recogida combinations
        builder.HasIndex(hs => new { hs.HotelId, hs.ScheduleId, hs.RecogidaNumber })
            .IsUnique();

        // Create date time for all records
        var currentTime = DateTime.UtcNow;

        builder.HasData(
            // SECRET CAP CANA (ID: 1)
            new HotelSchedule
            {
                Id = 1, HotelId = 1, ScheduleId = 1, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:25
            new HotelSchedule
            {
                Id = 2, HotelId = 1, ScheduleId = 27, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:35

            // HYATT ZILARA (ID: 2)
            new HotelSchedule
            {
                Id = 3, HotelId = 2, ScheduleId = 2, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:30
            new HotelSchedule
            {
                Id = 4, HotelId = 2, ScheduleId = 28, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:40

            // HYATT ZIVA (ID: 3)
            new HotelSchedule
            {
                Id = 5, HotelId = 3, ScheduleId = 3, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:35
            new HotelSchedule
            {
                Id = 6, HotelId = 3, ScheduleId = 29, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:45

            // SPORTS ILLUSTRATED (ID: 4)
            new HotelSchedule
            {
                Id = 7, HotelId = 4, ScheduleId = 4, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:40
            new HotelSchedule
            {
                Id = 8, HotelId = 4, ScheduleId = 30, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:50

            // TRS CAP CANA (ID: 5)
            new HotelSchedule
            {
                Id = 9, HotelId = 5, ScheduleId = 5, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:45
            new HotelSchedule
            {
                Id = 10, HotelId = 5, ScheduleId = 31, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:55

            // WESTIN PUNTA CANA (ID: 6)
            new HotelSchedule
            {
                Id = 11, HotelId = 6, ScheduleId = 12, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:20
            new HotelSchedule
            {
                Id = 12, HotelId = 6, ScheduleId = 45, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 4:35

            // FOUR POINTS (ID: 7)
            new HotelSchedule
            {
                Id = 13, HotelId = 7, ScheduleId = 13, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:25
            new HotelSchedule
            {
                Id = 14, HotelId = 7, ScheduleId = 45, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 4:45

            // DREAMS FLORA (ID: 8)
            new HotelSchedule
            {
                Id = 15, HotelId = 8, ScheduleId = 4, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:40
            new HotelSchedule
            {
                Id = 16, HotelId = 8, ScheduleId = 37, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:40

            // JEWEL PALM BEACH (ID: 9)
            new HotelSchedule
            {
                Id = 17, HotelId = 9, ScheduleId = 5, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:45
            new HotelSchedule
            {
                Id = 18, HotelId = 9, ScheduleId = 38, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:45

            // SUNSCAPE COCO PUNTA CANA (ID: 10)
            new HotelSchedule
            {
                Id = 19, HotelId = 10, ScheduleId = 6, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:50
            new HotelSchedule
            {
                Id = 20, HotelId = 10, ScheduleId = 46, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:50

            // SERENADE (ID: 11)
            new HotelSchedule
            {
                Id = 21, HotelId = 11, ScheduleId = 7, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:53
            new HotelSchedule
            {
                Id = 22, HotelId = 11, ScheduleId = 40, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:53

            // CATALONIA BAVARO (ID: 12)
            new HotelSchedule
            {
                Id = 23, HotelId = 12, ScheduleId = 8, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:55
            new HotelSchedule
            {
                Id = 24, HotelId = 12, ScheduleId = 41, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:55

            // CATALONIA ROYAL (ID: 13)
            new HotelSchedule
            {
                Id = 25, HotelId = 13, ScheduleId = 9, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:00
            new HotelSchedule
            {
                Id = 26, HotelId = 13, ScheduleId = 42, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 4:00

            // RIU REPUBLICA (ID: 14)
            new HotelSchedule
            {
                Id = 27, HotelId = 14, ScheduleId = 10, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:05
            new HotelSchedule
            {
                Id = 28, HotelId = 14, ScheduleId = 68, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 10:40
            new HotelSchedule
            {
                Id = 29, HotelId = 14, ScheduleId = 43, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 3:30

            // BAHIA PRINCIPE (BARRERA) (ID: 15)
            new HotelSchedule
            {
                Id = 30, HotelId = 15, ScheduleId = 11, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:10
            new HotelSchedule
            {
                Id = 31, HotelId = 15, ScheduleId = 69, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 10:45
            new HotelSchedule
            {
                Id = 32, HotelId = 15, ScheduleId = 44, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 3:35

            // RIU PUNTA CANA (ID: 16)
            new HotelSchedule
            {
                Id = 33, HotelId = 16, ScheduleId = 4, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:20
            new HotelSchedule
            {
                Id = 34, HotelId = 16, ScheduleId = 70, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 10:55
            new HotelSchedule
            {
                Id = 35, HotelId = 16, ScheduleId = 37, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 3:45

            // RIU BAMBU (ID: 17)
            new HotelSchedule
            {
                Id = 36, HotelId = 17, ScheduleId = 1, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:25
            new HotelSchedule
            {
                Id = 37, HotelId = 17, ScheduleId = 71, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 38, HotelId = 17, ScheduleId = 46, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 3:50

            // RIU MACAO (ID: 18)
            new HotelSchedule
            {
                Id = 39, HotelId = 18, ScheduleId = 2, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:30
            new HotelSchedule
            {
                Id = 40, HotelId = 18, ScheduleId = 72, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 11:05
            new HotelSchedule
            {
                Id = 41, HotelId = 18, ScheduleId = 47, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 3:55

            // RIU BAVARO (ID: 19)
            new HotelSchedule
            {
                Id = 42, HotelId = 19, ScheduleId = 3, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:35
            new HotelSchedule
            {
                Id = 43, HotelId = 19, ScheduleId = 73, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 44, HotelId = 19, ScheduleId = 42, RecogidaNumber = 3, CreatedTime = currentTime, IsActive = true
            }, // 4:00

            // HARD ROCK (ID: 20)
            new HotelSchedule
            {
                Id = 45, HotelId = 20, ScheduleId = 15, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:45
            new HotelSchedule
            {
                Id = 46, HotelId = 20, ScheduleId = 50, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:40

            // OCCIDENTAL CARIBE (ID: 21)
            new HotelSchedule
            {
                Id = 47, HotelId = 21, ScheduleId = 16, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:55
            new HotelSchedule
            {
                Id = 48, HotelId = 21, ScheduleId = 29, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:45
            new HotelSchedule
            {
                Id = 49, HotelId = 21, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // ROYALTON PUNTA CANA (ID: 22)
            new HotelSchedule
            {
                Id = 50, HotelId = 22, ScheduleId = 16, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:55
            new HotelSchedule
            {
                Id = 51, HotelId = 22, ScheduleId = 29, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:45
            new HotelSchedule
            {
                Id = 52, HotelId = 22, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // MAJESTIC COLONIAL (ID: 23)
            new HotelSchedule
            {
                Id = 53, HotelId = 23, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 54, HotelId = 23, ScheduleId = 30, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:50
            new HotelSchedule
            {
                Id = 55, HotelId = 23, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // MAJESTIC ELEGANCE (ID: 24)
            new HotelSchedule
            {
                Id = 56, HotelId = 24, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 57, HotelId = 24, ScheduleId = 30, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:50
            new HotelSchedule
            {
                Id = 58, HotelId = 24, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // MAJESTIC MIRAGE (ID: 25)
            new HotelSchedule
            {
                Id = 59, HotelId = 25, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 60, HotelId = 25, ScheduleId = 30, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:50
            new HotelSchedule
            {
                Id = 61, HotelId = 25, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // ROYALTON BAVARO (ID: 26)
            new HotelSchedule
            {
                Id = 62, HotelId = 26, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 63, HotelId = 26, ScheduleId = 30, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:50
            new HotelSchedule
            {
                Id = 64, HotelId = 26, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // IBEROSTAR PUNTA CANA (ID: 27)
            new HotelSchedule
            {
                Id = 65, HotelId = 27, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 66, HotelId = 27, ScheduleId = 33, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:10
            new HotelSchedule
            {
                Id = 67, HotelId = 27, ScheduleId = 55, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:10

            // IBEROSTAR DOMINICANA (ID: 28)
            new HotelSchedule
            {
                Id = 68, HotelId = 28, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 69, HotelId = 28, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15
            new HotelSchedule
            {
                Id = 70, HotelId = 28, ScheduleId = 56, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:15

            // IBEROSTAR SELECTION BAVARO (ID: 29)
            new HotelSchedule
            {
                Id = 71, HotelId = 29, ScheduleId = 21, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:20
            new HotelSchedule
            {
                Id = 72, HotelId = 29, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 73, HotelId = 29, ScheduleId = 57, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:20

            // IBEROSTAR BAVARO (ID: 30)
            new HotelSchedule
            {
                Id = 74, HotelId = 30, ScheduleId = 22, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:25
            new HotelSchedule
            {
                Id = 75, HotelId = 30, ScheduleId = 36, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:25
            new HotelSchedule
            {
                Id = 76, HotelId = 30, ScheduleId = 58, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:25

            // VISTA SOL PUNTA CANA (ID: 31)
            new HotelSchedule
            {
                Id = 77, HotelId = 31, ScheduleId = 14, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:40
            new HotelSchedule
            {
                Id = 78, HotelId = 31, ScheduleId = 23, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:10

            // WHALA BAVARO (ID: 32)
            new HotelSchedule
            {
                Id = 79, HotelId = 32, ScheduleId = 15, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:45
            new HotelSchedule
            {
                Id = 80, HotelId = 32, ScheduleId = 24, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:15

            // SECRETS ROYAL BEACH (ID: 33)
            new HotelSchedule
            {
                Id = 81, HotelId = 33, ScheduleId = 16, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 10:55
            new HotelSchedule
            {
                Id = 82, HotelId = 33, ScheduleId = 25, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:25

            // DREAMS ROYAL BEACH (ID: 34)
            new HotelSchedule
            {
                Id = 83, HotelId = 34, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 84, HotelId = 34, ScheduleId = 26, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:30

            // DREAMS ROYAL BEACH (PREFERRED) (ID: 35)
            new HotelSchedule
            {
                Id = 85, HotelId = 35, ScheduleId = 18, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:05
            new HotelSchedule
            {
                Id = 86, HotelId = 35, ScheduleId = 27, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 2:35

            // IMPRESSIVE (ID: 36)
            new HotelSchedule
            {
                Id = 87, HotelId = 36, ScheduleId = 17, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:00
            new HotelSchedule
            {
                Id = 88, HotelId = 36, ScheduleId = 50, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:40

            // MELIA CARIBE BEACH (ID: 37)
            new HotelSchedule
            {
                Id = 89, HotelId = 37, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 90, HotelId = 37, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // MELIA CARIBE TROPICAL (ID: 38)
            new HotelSchedule
            {
                Id = 91, HotelId = 38, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 92, HotelId = 38, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // MELIA PUNTA CANA BEACH (ID: 39)
            new HotelSchedule
            {
                Id = 93, HotelId = 39, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 94, HotelId = 39, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // PARADISUS PALMA REAL (ID: 40)
            new HotelSchedule
            {
                Id = 95, HotelId = 40, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 96, HotelId = 40, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // LOPESAN COSTA BAVARO (ID: 41)
            new HotelSchedule
            {
                Id = 97, HotelId = 41, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 98, HotelId = 41, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:50

            // BARCELO BAVARO BEACH (ID: 42)
            new HotelSchedule
            {
                Id = 99, HotelId = 42, ScheduleId = 21, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:20
            new HotelSchedule
            {
                Id = 100, HotelId = 42, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // BARCELO BAVARO PALACE (ID: 43)
            new HotelSchedule
            {
                Id = 101, HotelId = 43, ScheduleId = 21, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:20
            new HotelSchedule
            {
                Id = 102, HotelId = 43, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // PUNTA CANA PRINCESS (ID: 44)
            new HotelSchedule
            {
                Id = 103, HotelId = 44, ScheduleId = 18, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:05
            new HotelSchedule
            {
                Id = 104, HotelId = 44, ScheduleId = 32, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:10
            new HotelSchedule
            {
                Id = 105, HotelId = 44, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:45

            // VIK ARENA BLANCA (ID: 45)
            new HotelSchedule
            {
                Id = 106, HotelId = 45, ScheduleId = 18, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:05
            new HotelSchedule
            {
                Id = 107, HotelId = 45, ScheduleId = 32, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:10
            new HotelSchedule
            {
                Id = 108, HotelId = 45, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:45

            // OCEAN BLUE AND SAND (ID: 46)
            new HotelSchedule
            {
                Id = 109, HotelId = 46, ScheduleId = 18, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:05
            new HotelSchedule
            {
                Id = 110, HotelId = 46, ScheduleId = 32, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:10
            new HotelSchedule
            {
                Id = 111, HotelId = 46, ScheduleId = 51, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:45

            // CARIBE DELUXE PRINCESS (ID: 47)
            new HotelSchedule
            {
                Id = 112, HotelId = 47, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 113, HotelId = 47, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15
            new HotelSchedule
            {
                Id = 114, HotelId = 47, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // TROPICAL DELUXE PRINCESS (ID: 48)
            new HotelSchedule
            {
                Id = 115, HotelId = 48, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 116, HotelId = 48, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15
            new HotelSchedule
            {
                Id = 117, HotelId = 48, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // BAVARO PRINCESS (ID: 49)
            new HotelSchedule
            {
                Id = 118, HotelId = 49, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 119, HotelId = 49, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15
            new HotelSchedule
            {
                Id = 120, HotelId = 49, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // OCCIDENTAL PUNTA CANA (ID: 50)
            new HotelSchedule
            {
                Id = 121, HotelId = 50, ScheduleId = 19, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:10
            new HotelSchedule
            {
                Id = 122, HotelId = 50, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15
            new HotelSchedule
            {
                Id = 123, HotelId = 50, ScheduleId = 52, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 4:55

            // GRAND BAVARO PRINCESS (ID: 51)
            new HotelSchedule
            {
                Id = 124, HotelId = 51, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 125, HotelId = 51, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 126, HotelId = 51, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // GRAND PALLADIUM BAVARO (ID: 52)
            new HotelSchedule
            {
                Id = 127, HotelId = 52, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 128, HotelId = 52, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 129, HotelId = 52, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // GRAND PALLADIUM PALACE (ID: 53)
            new HotelSchedule
            {
                Id = 130, HotelId = 53, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 131, HotelId = 53, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 132, HotelId = 53, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // GRAND PALLADIUM PUNTA CANA (ID: 54)
            new HotelSchedule
            {
                Id = 133, HotelId = 54, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 134, HotelId = 54, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 135, HotelId = 54, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // GRAND PALLADIUM TRS TURQUESA (ID: 55)
            new HotelSchedule
            {
                Id = 136, HotelId = 55, ScheduleId = 20, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 11:15
            new HotelSchedule
            {
                Id = 137, HotelId = 55, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20
            new HotelSchedule
            {
                Id = 138, HotelId = 55, ScheduleId = 54, RecogidaNumber = 4, CreatedTime = currentTime, IsActive = true
            }, // 5:00

            // ZOETRY AGUA (ID: 56)
            new HotelSchedule
            {
                Id = 139, HotelId = 56, ScheduleId = 59, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 8:45
            new HotelSchedule
            {
                Id = 140, HotelId = 56, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15

            // EXCELLENCE PUNTA CANA (ID: 57)
            new HotelSchedule
            {
                Id = 141, HotelId = 57, ScheduleId = 60, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 8:50
            new HotelSchedule
            {
                Id = 142, HotelId = 57, ScheduleId = 34, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:15

            // SIRENIS (ID: 58)
            new HotelSchedule
            {
                Id = 143, HotelId = 58, ScheduleId = 61, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 8:55
            new HotelSchedule
            {
                Id = 144, HotelId = 58, ScheduleId = 35, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:20

            // SECRETS TIDES PUNTA CANA (ID: 59)
            new HotelSchedule
            {
                Id = 145, HotelId = 59, ScheduleId = 61, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 8:55
            new HotelSchedule
            {
                Id = 146, HotelId = 59, ScheduleId = 36, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:25

            // BREATHLESS PUNTA CANA (ID: 60)
            new HotelSchedule
            {
                Id = 147, HotelId = 60, ScheduleId = 62, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:00
            new HotelSchedule
            {
                Id = 148, HotelId = 60, ScheduleId = 37, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:30

            // DREAMS ONYX PUNTA CANA (ID: 61)
            new HotelSchedule
            {
                Id = 149, HotelId = 61, ScheduleId = 63, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:05
            new HotelSchedule
            {
                Id = 150, HotelId = 61, ScheduleId = 38, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:35

            // JEWEL PUNTA CANA (ID: 62)
            new HotelSchedule
            {
                Id = 151, HotelId = 62, ScheduleId = 64, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:10
            new HotelSchedule
            {
                Id = 152, HotelId = 62, ScheduleId = 39, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:40

            // ROYALTON CHIC (ID: 63)
            new HotelSchedule
            {
                Id = 153, HotelId = 63, ScheduleId = 65, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:15
            new HotelSchedule
            {
                Id = 154, HotelId = 63, ScheduleId = 39, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:40

            // NICKELODEON (ID: 64)
            new HotelSchedule
            {
                Id = 155, HotelId = 64, ScheduleId = 65, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:15
            new HotelSchedule
            {
                Id = 156, HotelId = 64, ScheduleId = 39, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:40

            // OCEAN EL FARO (ID: 65)
            new HotelSchedule
            {
                Id = 157, HotelId = 65, ScheduleId = 66, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:20
            new HotelSchedule
            {
                Id = 158, HotelId = 65, ScheduleId = 40, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            }, // 3:45

            // DREAMS MACAO (ID: 66)
            new HotelSchedule
            {
                Id = 159, HotelId = 66, ScheduleId = 67, RecogidaNumber = 1, CreatedTime = currentTime, IsActive = true
            }, // 9:25
            new HotelSchedule
            {
                Id = 160, HotelId = 66, ScheduleId = 41, RecogidaNumber = 2, CreatedTime = currentTime, IsActive = true
            } // 3:55)
        );
    }
}
    