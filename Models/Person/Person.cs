namespace Ecotech.Models;

public class Person
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string CPF { get; set; }

    public required string Email { get; set; }
    public required string PhoneNumberPrimary { get; set; }
    public required string PhoneNumberSecondary { get; set; }
    public Address? Address { get; set; }
}