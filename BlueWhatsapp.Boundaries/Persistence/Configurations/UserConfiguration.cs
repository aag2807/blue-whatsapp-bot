using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWhatsapp.Boundaries.Persistence.Configurations;


public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(u => u.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(u => u.Email)
            .IsUnique();

        builder.HasData(new User
        {
            Id = 1,
            Name = "Admin",
            Email = "admin@admin.com",
            Password = PasswordUtils.HashPassword("admin")
        },
        new User
        {
            Id = 2,
            Name = "Diana",
            Email = "dmartinez@bluemall.com.do",
            Password = PasswordUtils.HashPassword("admin")
        },
        new User
        {
            Id = 3,
            Name = "reservas",
            Email = "reservas@bluemall.com.do",
            Password = PasswordUtils.HashPassword("password123")
        },
        new User
        {
            Id = 4,
            Name = "Murena",
            Email = "murena@bluemall.com.do",
            Password = PasswordUtils.HashPassword("password123")
        }
        );
    }
}
