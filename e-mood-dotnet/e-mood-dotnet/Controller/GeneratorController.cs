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
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
        });
        _context.Users.Add(new User()
        {
            Name = "Ivan",
            Surname = "Ivanov",
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
        });
        _context.Users.Add(new User()
        {
            Name = "Varvara",
            Surname = "Evseeva",
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
        });
        _context.Users.Add(new User()
        {
            Name = "Bob",
            Surname = "Seriy",
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
        });
        _context.Users.Add(new User()
        {
            Name = "Igor",
            Surname = "Evseev",
            PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
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
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Title = "Stand or Fall",
                    Artist = "Bonfire",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Bonfire_-_Stand_or_Fall.mp3",
                },
                new Track()
                {
                    Title = "Love And Pain",
                    Artist = "Captain Hollywood Project",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Captain_Hollywood_Project_-_Love_And_Pain.mp3"
                },
                new Track()
                {
                    Title = "Mary Leigh",
                    Artist = "Eclipse",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Eclipse_-_Mary_Leigh.mp3",
                },
                new Track()
                {
                    Title = "Moscow Calling",
                    Artist = "Gorky Park",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Gorky_Park_-_Moscow_Calling.mp3",
                },
                new Track()
                {
                    Title = "Heavens On Fire",
                    Artist = "Kiss",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Kiss_-_Heavens_On_Fire.mp3",
                },
                new Track()
                {
                    Title = "She Goes Down",
                    Artist = "Lea Hart",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Lea_Hart_-_She_Goes_Down.mp3",
                },
                new Track()
                {
                    Title = "Billie Jean",
                    Artist = "Michael Jackson",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Michael_Jackson_-_Billie_Jean.mp3",
                },
                new Track()
                {
                    Title = "Madness",
                    Artist = "Muse",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Muse_-_Madness.mp3",
                },
                new Track()
                {
                    Title = "We Are The Champions",
                    Artist = "Queen",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Queen_-_We_Are_The_Champions.mp3",
                },
                new Track()
                {
                    Title = "We Will Rock You",
                    Artist = "Queen",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Queen_-_We_Will_Rock_You.mp3",
                },
                new Track()
                {
                    Title = "There Must Be More To Life Than This",
                    Artist = "Queen & Michael Jackson",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://mood.eureka-team.ru/api/Files/Content/Queen_Michael_Jackson_There_Must_Be_More_To_Life_Than_This.mp3",
                }
            },
            OwnerId = Guid.NewGuid()
        });

        await _context.SaveChangesAsync();

        return Ok();
    }
}