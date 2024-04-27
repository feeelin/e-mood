using Microsoft.AspNetCore.Mvc;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly MusicDbContext _context;

        public UserController(
            MusicDbContext context,
            ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("get-user")]
        public async Task<User> GetUser()
        {
            return new User()
            {
                Name = "Sergey Evseev"
            };
        }
        
        [HttpGet("list-users")]
        public async Task<IEnumerable<User>> ListUsers()
        {
            return Enumerable.Range(1, 5).Select(index => new User()
                {
                    Id = index,
                    Name = index.ToString()
                })
                .ToArray();
        }
        
        
        [HttpPost("create-user")]
        public async Task<User> CreateUser()
        {
            var user = new User()
            {
                Id = 1,
                Name = "test playlist"
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}