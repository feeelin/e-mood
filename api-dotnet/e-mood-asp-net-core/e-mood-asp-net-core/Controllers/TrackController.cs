using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        }

        // POST: HomeController/Edit/5
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
        }
    }
}
