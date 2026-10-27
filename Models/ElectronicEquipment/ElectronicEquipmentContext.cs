using Microsoft.EntityFrameworkCore;

namespace Ecotech.Models;

public class ElectronicEquipmentContext : DbContext
{
    public ElectronicEquipmentContext(DbContextOptions<ElectronicEquipmentContext> options) : base(options)
    {

    }

    public DbSet<ElectronicEquipment> ElectronicEquipments { get; set; } = null!;

}