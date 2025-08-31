using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;
public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<IdentityUser>().HasData(GetUserSeeds());
        builder.Entity<IdentityRole>().HasData(GetRoleSeeds());
        builder.Entity<IdentityUserRole<string>>().HasData(GetUserRoleSeeds());

        base.OnModelCreating(builder);
    }

    internal static List<IdentityUser> GetUserSeeds()
    {
        List<IdentityUser> users = [];

        users.Add(new()
        {
            Id = "5662ecf4-3b04-4091-91c1-6d29b7040143",
            UserName = "admin@admin.com",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            NormalizedUserName = "ADMIN@ADMIN.COM",
            PasswordHash = "AQAAAAIAAYagAAAAEIVbNTA3h9OmvRr7jjqgk+b3H//tLTncNFdmUmAQpCuF+FDRsLebLQkI5XRATx+7EQ==",
            PhoneNumber = "",
            TwoFactorEnabled = false,
            LockoutEnabled = false,
            PhoneNumberConfirmed = false,
            LockoutEnd = null,
            SecurityStamp = "82254947-b832-4e32-b933-ed554d10394f",
            ConcurrencyStamp = null,
            AccessFailedCount = 0
        });

        return users;
    }

    internal static List<IdentityRole> GetRoleSeeds()
    {
        List<IdentityRole> roles = [];

        roles.Add(new()
        {
            Id = "93cdbbbb-2469-4669-a286-35897df1c980",
            Name = "Admin",
            NormalizedName = "ADMIN"
        });

        return roles;
    }

    internal static List<IdentityUserRole<string>> GetUserRoleSeeds()
    {
        List<IdentityUserRole<string>> userRoles = [];

        userRoles.Add(new()
        {
            UserId = "5662ecf4-3b04-4091-91c1-6d29b7040143",
            RoleId = "93cdbbbb-2469-4669-a286-35897df1c980"
        });

        return userRoles;
    }
}