namespace Ecotech.Models;

public class Favorite
{
    public required string UserId { get; set; }
    public required string AdvertisementId { get; set; }

    public required Person User { get; set; }
    public required Advertisement Advertisement { get; set; }
}