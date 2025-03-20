using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;

public class ScheduleConfiguration :  IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.ToTable("Schedules");

        builder.Property(s => s.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder.Property(s => s.Name)
            .IsRequired();

        builder.Property(s => s.Time)
            .IsRequired();

        builder.HasMany<Hotel>()
            .WithMany(h => h.Schedules)
            .UsingEntity<HotelSchedule>(
                j => j.HasOne(hs => hs.Hotel)
                    .WithMany()
                    .HasForeignKey(hs => hs.HotelId),
                j => j.HasOne(hs => hs.Schedule)
                    .WithMany(s => s.HotelSchedules)
                    .HasForeignKey(hs => hs.ScheduleId)
            );
        
        // Create date time for all records
        var currentTime = DateTime.UtcNow;

        builder.HasData(
            // Recogida 1 (first pickup) schedules
            new Schedule { Id = 1, Name = "09:25", Time = "09:25", CreatedTime = currentTime },
            new Schedule { Id = 2, Name = "09:30", Time = "09:30", CreatedTime = currentTime },
            new Schedule { Id = 3, Name = "09:35", Time = "09:35", CreatedTime = currentTime },
            new Schedule { Id = 4, Name = "09:40", Time = "09:40", CreatedTime = currentTime },
            new Schedule { Id = 5, Name = "09:45", Time = "09:45", CreatedTime = currentTime },
            new Schedule { Id = 6, Name = "09:50", Time = "09:50", CreatedTime = currentTime },
            new Schedule { Id = 7, Name = "09:53", Time = "09:53", CreatedTime = currentTime },
            new Schedule { Id = 8, Name = "09:55", Time = "09:55", CreatedTime = currentTime },
            new Schedule { Id = 9, Name = "10:00", Time = "10:00", CreatedTime = currentTime },
            new Schedule { Id = 10, Name = "10:05", Time = "10:05", CreatedTime = currentTime },
            new Schedule { Id = 11, Name = "10:10", Time = "10:10", CreatedTime = currentTime },
            new Schedule { Id = 12, Name = "10:20", Time = "10:20", CreatedTime = currentTime },
            new Schedule { Id = 13, Name = "10:25", Time = "10:25", CreatedTime = currentTime },
            new Schedule { Id = 14, Name = "10:40", Time = "10:40", CreatedTime = currentTime },
            new Schedule { Id = 15, Name = "10:45", Time = "10:45", CreatedTime = currentTime },
            new Schedule { Id = 16, Name = "10:55", Time = "10:55", CreatedTime = currentTime },
            new Schedule { Id = 17, Name = "11:00", Time = "11:00", CreatedTime = currentTime },
            new Schedule { Id = 18, Name = "11:05", Time = "11:05", CreatedTime = currentTime },
            new Schedule { Id = 19, Name = "11:10", Time = "11:10", CreatedTime = currentTime },
            new Schedule { Id = 20, Name = "11:15", Time = "11:15", CreatedTime = currentTime },
            new Schedule { Id = 21, Name = "11:20", Time = "11:20", CreatedTime = currentTime },
            new Schedule { Id = 22, Name = "11:25", Time = "11:25", CreatedTime = currentTime },
            
            // Recogida 2 (second pickup) schedules
            new Schedule { Id = 23, Name = "2:10", Time = "2:10", CreatedTime = currentTime },
            new Schedule { Id = 24, Name = "2:15", Time = "2:15", CreatedTime = currentTime },
            new Schedule { Id = 25, Name = "2:25", Time = "2:25", CreatedTime = currentTime },
            new Schedule { Id = 26, Name = "2:30", Time = "2:30", CreatedTime = currentTime },
            new Schedule { Id = 27, Name = "2:35", Time = "2:35", CreatedTime = currentTime },
            new Schedule { Id = 28, Name = "2:40", Time = "2:40", CreatedTime = currentTime },
            new Schedule { Id = 29, Name = "2:45", Time = "2:45", CreatedTime = currentTime },
            new Schedule { Id = 30, Name = "2:50", Time = "2:50", CreatedTime = currentTime },
            new Schedule { Id = 31, Name = "2:55", Time = "2:55", CreatedTime = currentTime },
            new Schedule { Id = 32, Name = "3:10", Time = "3:10", CreatedTime = currentTime },
            new Schedule { Id = 33, Name = "3:15", Time = "3:15", CreatedTime = currentTime },
            new Schedule { Id = 34, Name = "3:20", Time = "3:20", CreatedTime = currentTime },
            new Schedule { Id = 35, Name = "3:25", Time = "3:25", CreatedTime = currentTime },
            new Schedule { Id = 36, Name = "3:30", Time = "3:30", CreatedTime = currentTime },
            new Schedule { Id = 37, Name = "3:40", Time = "3:40", CreatedTime = currentTime },
            new Schedule { Id = 38, Name = "3:45", Time = "3:45", CreatedTime = currentTime },
            new Schedule { Id = 39, Name = "3:50", Time = "3:50", CreatedTime = currentTime },
            new Schedule { Id = 40, Name = "3:53", Time = "3:53", CreatedTime = currentTime },
            new Schedule { Id = 41, Name = "3:55", Time = "3:55", CreatedTime = currentTime },
            new Schedule { Id = 42, Name = "4:00", Time = "4:00", CreatedTime = currentTime },
            
            // Recogida 3 (third pickup) schedules
            new Schedule { Id = 43, Name = "3:30", Time = "3:30", CreatedTime = currentTime },
            new Schedule { Id = 44, Name = "3:35", Time = "3:35", CreatedTime = currentTime },
            new Schedule { Id = 45, Name = "3:45", Time = "3:45", CreatedTime = currentTime },
            new Schedule { Id = 46, Name = "3:50", Time = "3:50", CreatedTime = currentTime },
            new Schedule { Id = 47, Name = "3:55", Time = "3:55", CreatedTime = currentTime },
            new Schedule { Id = 48, Name = "4:00", Time = "4:00", CreatedTime = currentTime },
            
            // Recogida 4 (fourth pickup) schedules
            new Schedule { Id = 49, Name = "4:35", Time = "4:35", CreatedTime = currentTime },
            new Schedule { Id = 50, Name = "4:40", Time = "4:40", CreatedTime = currentTime },
            new Schedule { Id = 51, Name = "4:45", Time = "4:45", CreatedTime = currentTime },
            new Schedule { Id = 52, Name = "4:50", Time = "4:50", CreatedTime = currentTime },
            new Schedule { Id = 53, Name = "4:55", Time = "4:55", CreatedTime = currentTime },
            new Schedule { Id = 54, Name = "5:00", Time = "5:00", CreatedTime = currentTime },
            new Schedule { Id = 55, Name = "5:10", Time = "5:10", CreatedTime = currentTime },
            new Schedule { Id = 56, Name = "5:15", Time = "5:15", CreatedTime = currentTime },
            new Schedule { Id = 57, Name = "5:20", Time = "5:20", CreatedTime = currentTime },
            new Schedule { Id = 58, Name = "5:25", Time = "5:25", CreatedTime = currentTime },
            
            // Additional special schedules
            new Schedule { Id = 59, Name = "8:45", Time = "8:45", CreatedTime = currentTime },
            new Schedule { Id = 60, Name = "8:50", Time = "8:50", CreatedTime = currentTime },
            new Schedule { Id = 61, Name = "8:55", Time = "8:55", CreatedTime = currentTime },
            new Schedule { Id = 62, Name = "9:00", Time = "9:00", CreatedTime = currentTime },
            new Schedule { Id = 63, Name = "9:05", Time = "9:05", CreatedTime = currentTime },
            new Schedule { Id = 64, Name = "9:10", Time = "9:10", CreatedTime = currentTime },
            new Schedule { Id = 65, Name = "9:15", Time = "9:15", CreatedTime = currentTime },
            new Schedule { Id = 66, Name = "9:20", Time = "9:20", CreatedTime = currentTime },
            new Schedule { Id = 67, Name = "9:25", Time = "9:25", CreatedTime = currentTime },
            new Schedule { Id = 68, Name = "10:40", Time = "10:40", CreatedTime = currentTime },
            new Schedule { Id = 69, Name = "10:45", Time = "10:45", CreatedTime = currentTime },
            new Schedule { Id = 70, Name = "10:55", Time = "10:55", CreatedTime = currentTime },
            new Schedule { Id = 71, Name = "11:00", Time = "11:00", CreatedTime = currentTime },
            new Schedule { Id = 72, Name = "11:05", Time = "11:05", CreatedTime = currentTime },
            new Schedule { Id = 73, Name = "11:10", Time = "11:10", CreatedTime = currentTime }
        );
    }
}