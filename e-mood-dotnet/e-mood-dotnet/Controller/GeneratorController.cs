using System.Security.Claims;
using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Controller;

[ApiController]
[Route("api/[controller]")]
public class GeneratorController : ControllerBase
{
    private readonly ILogger<GeneratorController> _logger;
    private readonly IMusicContext _context;

    public GeneratorController(
        ILogger<GeneratorController> logger,
        IMusicContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [HttpGet("GenerateData")]
    public async Task<IActionResult> GetGenerator()
    {
        _context.Users.Add(new User()
        {
            Name = "Sergey",
            Surname = "Evseev",
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
        });
        
        _context.Playlists.Add(new Playlist()
        {
            Name = "Sergey",
            Description = "Evseev",
            CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Subscribers = new List<User>()
            {
                new User()
                {
                    Name = "Sergey",
                    Surname = "Evseev",
                    PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
                }
            },
            OwnerId = Guid.NewGuid()
        });

        _context.Tracks.Add(new Track()
        {
            Title = "Never gonna give you up",
            Artist = "Rick Astley",
            Duration = TimeSpan.FromSeconds(120),
            Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Playlist = new Playlist()
            {
                Name = "Sergey",
                Description = "Evseev",
                CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                OwnerId = Guid.NewGuid()
            }
        });
        
        return Ok();
    }
}