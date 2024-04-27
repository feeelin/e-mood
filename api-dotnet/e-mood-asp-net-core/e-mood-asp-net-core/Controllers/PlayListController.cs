<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
<<<<<<< HEAD
    public class PlayListController : Controller
    {
        private readonly MusicDbContext db;
        public PlayListController(MusicDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playList = await db.PlayLists
                .Include(s => s.Name)
                    //.ThenInclude(e => e.Group)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (playList == null)
            {
                return NotFound();
            }

            return View(playList);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlayList playList)
        {
            db.PlayLists.Add(playList);
            await db.SaveChangesAsync();
            return Ok();
=======
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
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
        }
        
        
        [HttpPost("create-playlist")]
        public async Task<PlayList> CreateGroup()
        {
            var playList = new PlayList()
            {
<<<<<<< HEAD
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

            var playList = await db.PlayLists
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playList == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(playList);
=======
                Id = 1,
                Name = "test playlist"
            };
            _context.PlayLists.Add(playList);
            await _context.SaveChangesAsync();
            return playList;
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
        }
    }
}