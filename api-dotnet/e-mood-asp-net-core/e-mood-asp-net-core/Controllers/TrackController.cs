using Microsoft.AspNetCore.Mvc;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackController : ControllerBase
    {
        private readonly ILogger<TrackController> _logger;
        private readonly MusicDbContext _context;

        public TrackController(
            MusicDbContext context,
            ILogger<TrackController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("get-track")]
        public async Task<Track> GetTrack()
        {
            return new Track()
            {
                Name = "Test track"
            };
        }
        
        [HttpGet("list-tracks")]
        public async Task<IEnumerable<Track>> ListTracks()
        {
            return Enumerable.Range(1, 5).Select(index => new Track()
                {
                    Id = index,
                    Name = index.ToString()
                })
                .ToArray();
        }
        
        
        [HttpPost("create-track")]
        public async Task<Track> CreateTrack()
        {
            var track = new Track()
            {
                Id = 1,
                Name = "test playlist"
            };
            _context.Tracks.Add(track);
            await _context.SaveChangesAsync();
            return track;
        }
    }
}