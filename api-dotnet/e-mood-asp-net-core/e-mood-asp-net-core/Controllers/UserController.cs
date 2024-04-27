using Microsoft.AspNetCore.Mvc;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
<<<<<<< HEAD
    public class UserController : Controller
    {
        private readonly MusicDbContext db;
        public UserController(MusicDbContext context) {
            db = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await db.Users
                .Include(s => s.Name)
                    //.ThenInclude(e => e.Surname)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: UserController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
=======
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
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
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
<<<<<<< HEAD

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(user);
        }
=======
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
    }
}