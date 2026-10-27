using Microsoft.EntityFrameworkCore;

namespace Ecotech.Models;

public class FavoriteContext : DbContext
{
    public FavoriteContext(DbContextOptions<FavoriteContext> options) : base(options)
    {

    }

    public DbSet<Favorite> Favorites { get; set; } = null!;
}