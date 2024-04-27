using Microsoft.AspNetCore.Mvc;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayListController : ControllerBase
    {
        private readonly ILogger<PlayListController> _logger;
        private readonly MusicDbContext _context;

        public PlayListController(
            MusicDbContext context,
            ILogger<PlayListController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("get-playlist")]
        public async Task<PlayList> GetPlaylist()
        {
            return new PlayList()
            {
                Name = "Test playlist"
            };
        }
        
        [HttpGet("list-playlists")]
        public async Task<IEnumerable<PlayList>> ListPlaylists()
        {
            return Enumerable.Range(1, 5).Select(index => new PlayList
                {
                    Id = index,
                    Name = index.ToString()
                })
                .ToArray();
        }
        
        
        [HttpPost("create-playlist")]
        public async Task<PlayList> CreateGroup()
        {
            var playList = new PlayList()
            {
                Id = 1,
                Name = "test playlist"
            };
            _context.PlayLists.Add(playList);
            await _context.SaveChangesAsync();
            return playList;
        }
    }
}