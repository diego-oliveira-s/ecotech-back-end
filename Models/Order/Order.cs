namespace Ecotech.Models;

public class Order
{
    public required string OrderId { get; set; }
    public required Person Donor { get; set; }
    public required Person Recipient { get; set; }
    public required Advertisement Advertisement { get; set; }
    public required OrderStatus OrderStatus { get; set; }
    public required List<ElectronicEquipment> Items { get; set; }

    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}

public enum OrderStatus
{
    Pending,
    Delivered,
    Cancelled
}