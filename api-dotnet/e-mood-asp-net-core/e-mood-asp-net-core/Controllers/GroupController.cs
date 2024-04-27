using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_asp_net_core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        private readonly MusicDbContext db;
        public GroupController(MusicDbContext context)
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

            var group = await db.Groups
                .Include(s => s.NameGroup)
                //.ThenInclude(e => e.Group)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (group == null)
            {
                return NotFound();
            }

            return View(group);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Group group)
        {
            db.Groups.Add(group);
            await db.SaveChangesAsync();
            return Ok();
        }

        // POST: GroupController/Edit/5
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

            var group = await db.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (group == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(group);
        }
    }
}
