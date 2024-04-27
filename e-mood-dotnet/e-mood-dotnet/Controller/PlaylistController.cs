using System.Security.Claims;
using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Controller;

[ApiController]
[Route("api/[controller]")]
[ProducesResponseType(typeof(Playlist), StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(Playlist), StatusCodes.Status403Forbidden)]
[ProducesResponseType(typeof(Playlist), StatusCodes.Status404NotFound)]
public class PlaylistController : ControllerBase
{
    private readonly ILogger<PlaylistController> _logger;
    private readonly IMusicContext _context;

    public PlaylistController(
        ILogger<PlaylistController> logger,
        IMusicContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [ProducesResponseType(typeof(Playlist), StatusCodes.Status200OK)]
    [HttpGet("GetPlaylist")]
    public async Task<IActionResult> GetPlaylist()
    {
        var playlist = await _context.Playlists
            .Include(item => item.Tracks)
            .FirstOrDefaultAsync();
        return Ok(playlist);
    }
    
    
    [ProducesResponseType(typeof(Playlist), StatusCodes.Status200OK)]
    [HttpGet("ListPlaylists")]
    public async Task<IActionResult> GetPlaylist(Guid id)
    {
        var playlist = await _context.Playlists
            .Include(item => item.Tracks)
            .ToListAsync();
        return Ok(playlist);
    }
    
    [ProducesResponseType(typeof(Playlist), StatusCodes.Status200OK)]
    [HttpPost("CreatePlaylist")]
    public async Task<IActionResult> CreatePlaylist(Playlist playlist)
    {
        await _context.Playlists.AddAsync(playlist);
        return Ok(playlist);
    }
}