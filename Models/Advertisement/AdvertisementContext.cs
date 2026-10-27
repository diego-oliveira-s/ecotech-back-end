using Microsoft.EntityFrameworkCore;

namespace Ecotech.Models;

public class AdvertisementContext : DbContext
{
    public AdvertisementContext(DbContextOptions<AdvertisementContext> options) : base(options)
    {

    }

    public DbSet<Advertisement> Advertisements { get; set; } = null!;

}