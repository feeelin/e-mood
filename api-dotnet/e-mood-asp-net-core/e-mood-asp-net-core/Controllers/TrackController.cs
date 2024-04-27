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
    public class TrackController : Controller
    {
        private readonly MusicDbContext db;
        public TrackController(MusicDbContext context)
        {
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

            var track = await db.Tracks
                .Include(s => s.Name)
                //.ThenInclude(e => e.Group)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Track track)
        {
            db.Tracks.Add(track);
            await db.SaveChangesAsync();
            return Ok();
=======
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
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
        }
        
        
        [HttpPost("create-track")]
        public async Task<Track> CreateTrack()
        {
            var track = new Track()
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

            var track = await db.Tracks
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (track == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(track);
=======
                Id = 1,
                Name = "test playlist"
            };
            _context.Tracks.Add(track);
            await _context.SaveChangesAsync();
            return track;
>>>>>>> 057a41ceaa65494bbbe10ae3a953b778c2afec4e
        }
    }
}