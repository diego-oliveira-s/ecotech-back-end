using Microsoft.EntityFrameworkCore;

namespace Ecotech.Models;

public class IdentityContext : DbContext
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {

    }

    public DbSet<Identity> Identities { get; set; } = null!;
}