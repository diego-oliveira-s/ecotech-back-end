using Ecotech.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace Ecotech.Data;

// IdentityDbContext adds the Identity tables (AspNetUsers, AspNetRoles, ...).
public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    public DbSet<ElectronicEquipment> ElectronicEquipments { get; set; } = null!;
    public DbSet<Person> PersonItems { get; set; } = null!;
    public DbSet<Favorite> Favorites { get; set; } = null!;
    public DbSet<Advertisement> Advertisements { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Required: configures the Identity tables.
        base.OnModelCreating(builder);

        builder.Entity<Favorite>().HasKey(f => new { f.UserId, f.AdvertisementId });
        builder.Entity<Person>().OwnsOne(p => p.Address);
        builder.Entity<Order>().HasKey(o => o.OrderId);

        // Two relationships to Person: be explicit so EF doesn't get confused.
        builder.Entity<Order>().HasOne(o => o.Donor).WithMany().OnDelete(DeleteBehavior.Restrict);
        builder.Entity<Order>().HasOne(o => o.Recipient).WithMany().OnDelete(DeleteBehavior.Restrict);
    }
}
