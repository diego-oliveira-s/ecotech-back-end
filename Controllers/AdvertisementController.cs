using Ecotech.Data;
using Ecotech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdvertisementController : ControllerBase
{
    private readonly AppDbContext _context;

    public AdvertisementController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Advertisement>>> GetAdvertisements([FromQuery] AdvertisementParameters parameters)
    {
        var query = _context.Advertisements.AsQueryable();

        if (!string.IsNullOrEmpty(parameters.Title))
        {
            query = query.Where(a => a.Title.Contains(parameters.Title));
        }

        var advertisements = await query.ToListAsync();


        return Ok(advertisements);

    }
}

public class AdvertisementParameters
{
    public string? Title { get; set; }
}
