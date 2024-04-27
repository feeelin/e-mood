using System.Security.Claims;
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
        var ssoUserClaim = HttpContext.User.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier);
        Guid.TryParse(ssoUserClaim.Value, out var userId);
        
        var user = await _context.Users
            .FirstOrDefaultAsync(user => user.Id == userId);

        if (user is null) return NotFound();

        return Ok(user);
    }
    
    
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [HttpGet("ListUsers")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(user => user.Id == id);

        if (user is null) return NotFound();

        return Ok(user);
    }

}