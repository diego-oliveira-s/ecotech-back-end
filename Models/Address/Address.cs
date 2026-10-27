namespace Ecotech.Models;

public class Address
{
    public required string Street { get; set; }
    public required string Neighborhood { get; set; }
    public required string Number { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
}
