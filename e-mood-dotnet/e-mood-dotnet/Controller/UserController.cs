using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Controller;

[ApiController]
[Route("api/[controller]")]
[ProducesResponseType(typeof(User), StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(User), StatusCodes.Status403Forbidden)]
[ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IMusicContext _context;

    public UserController(
        ILogger<UserController> logger,
        IMusicContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [HttpGet("GetUser")]
    public async Task<IActionResult> GetUser()
    {
        var user = await _context.Users.FirstOrDefaultAsync();
        return Ok(user);
    }
    
    
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [HttpGet("ListUsers")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var user = await _context.Users.ToListAsync();
        return Ok(user);
    }
    
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [HttpPost("AddFavouritePlaylist")]
    public async Task<IActionResult> AddFavouritePlaylist(Guid userId, Guid playlistId)
    {
        var user = await _context.Users.FirstAsync(item => item.Id == userId);
        var playlist = await _context.Playlists.FirstAsync(item => item.Id == playlistId);
        playlist.Subscribers.Add(user);
        await _context.SaveChangesAsync();
        return Ok(user);
    }

}