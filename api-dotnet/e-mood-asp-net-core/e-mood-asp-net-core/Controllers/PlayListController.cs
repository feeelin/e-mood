using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        }

        // POST: PlayListController/Edit/5
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
        }
    }
}
