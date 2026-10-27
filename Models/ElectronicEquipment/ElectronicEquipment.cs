namespace Ecotech.Models;

public class ElectronicEquipment
{
    public required long Id { get; set; }
    public required string Type { get; set; }
    public required string Description { get; set; }
    public required string ImageUrl { get; set; }
    public required string Donor { get; set; }
}
