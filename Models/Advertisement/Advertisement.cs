namespace Ecotech.Models;

public class Advertisement
{
    public required string Id { get; set; }
    public required string Title { get; set; }
    public required string StockAmount { get; set; }
    public required ElectronicEquipment ElectronicEquipment { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}