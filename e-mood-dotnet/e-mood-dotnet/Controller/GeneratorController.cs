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
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                },
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                }
            },
            OwnerId = Guid.NewGuid()
        });
        _context.Playlists.Add(new Playlist()
        {
            Name = "Ivan",
            Description = "Ivanov",
            CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Subscribers = new List<User>()
            {
                new User()
                {
                    Name = "Ivan",
                    Surname = "Ivanov",
                    PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
                }
            },
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                },
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                }
            },
            OwnerId = Guid.NewGuid()
        });
        
        _context.Playlists.Add(new Playlist()
        {
            Name = "Varvara",
            Description = "Evseeva",
            CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Subscribers = new List<User>()
            {
                new User()
                {
                    Name = "Varvara",
                    Surname = "Evseeva",
                    PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
                }
            },
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                },
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                }
            },
            OwnerId = Guid.NewGuid()
        });
        
        _context.Playlists.Add(new Playlist()
        {
            Name = "Bob",
            Description = "Seriy",
            CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Subscribers = new List<User>()
            {
                new User()
                {
                    Name = "Bob",
                    Surname = "Seriy",
                    PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
                }
            },
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                },
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                }
            },
            OwnerId = Guid.NewGuid()
        });
        
        _context.Playlists.Add(new Playlist()
        {
            Name = "Igor",
            Description = "Evseev",
            CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Subscribers = new List<User>()
            {
                new User()
                {
                    Name = "Igor",
                    Surname = "Evseev",
                    PictureUrl = "https://cdn.eureka-team.ru/avatar/hacker.png"
                }
            },
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
                },
                new Track()
                {
                    Title = "Wait For Me",
                    Artist = "Jeff The second",
                    Duration = TimeSpan.FromSeconds(120),
                    Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
                    Playlist = new Playlist()
                    {
                        Name = "Igor",
                        Description = "Evseev",
                        CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                        OwnerId = Guid.NewGuid()
                    }
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
        _context.Tracks.Add(new Track()
        {
            Title = "Gonna Get Tou Someday",
            Artist = "Wig Wam",
            Duration = TimeSpan.FromSeconds(120),
            Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Playlist = new Playlist()
            {
                Name = "Ivan",
                Description = "Ivanov",
                CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                OwnerId = Guid.NewGuid()
            }
        });
        _context.Tracks.Add(new Track()
        {
            Title = "Rock You Like a Hurricane",
            Artist = "Scorpions",
            Duration = TimeSpan.FromSeconds(120),
            Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Playlist = new Playlist()
            {
                Name = "Varvara",
                Description = "Evseeva",
                CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                OwnerId = Guid.NewGuid()
            }
        });
        _context.Tracks.Add(new Track()
        {
            Title = "We're Gonna Make If",
            Artist = "Twisted Sister",
            Duration = TimeSpan.FromSeconds(120),
            Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Playlist = new Playlist()
            {
                Name = "Bob",
                Description = "Seriy",
                CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                OwnerId = Guid.NewGuid()
            }
        });
        _context.Tracks.Add(new Track()
        {
            Title = "Wait For Me",
            Artist = "Jeff The second",
            Duration = TimeSpan.FromSeconds(120),
            Url = "https://cdn.eureka-team.ru/avatar/hacker.png",
            Playlist = new Playlist()
            {
                Name = "Igor",
                Description = "Evseev",
                CoverUrl = "https://cdn.eureka-team.ru/avatar/hacker.png",
                OwnerId = Guid.NewGuid()
            }
        });

        await _context.SaveChangesAsync();
        
        return Ok();
    }
}