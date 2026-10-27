using Microsoft.EntityFrameworkCore;

namespace Ecotech.Models;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {

    }

    public DbSet<Person> PersonItems { get; set; } = null!;
}