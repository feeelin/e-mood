using System.Security.Claims;
using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Controller;

[ApiController]
[Route("api/[controller]")]
[ProducesResponseType(typeof(Track), StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(Track), StatusCodes.Status403Forbidden)]
[ProducesResponseType(typeof(Track), StatusCodes.Status404NotFound)]
public class TrackController : ControllerBase
{
    private readonly ILogger<TrackController> _logger;
    private readonly IMusicContext _context;

    public TrackController(
        ILogger<TrackController> logger,
        IMusicContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [ProducesResponseType(typeof(Track), StatusCodes.Status200OK)]
    [HttpGet("GetTrack")]
    public async Task<IActionResult> GetTrack()
    {
        var ssoTrackClaim = HttpContext.User.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier);
        Guid.TryParse(ssoTrackClaim.Value, out var TrackId);
        
        var track = await _context.Tracks
            .FirstOrDefaultAsync(Track => Track.Id == TrackId);

        if (track is null) return NotFound();

        return Ok(track);
    }
    
    
    [ProducesResponseType(typeof(Track), StatusCodes.Status200OK)]
    [HttpGet("ListTracks")]
    public async Task<IActionResult> GetTrack(Guid id)
    {
        var track = await _context.Tracks
            .FirstOrDefaultAsync(Track => Track.Id == id);

        if (track is null) return NotFound();

        return Ok(track);
    }

}