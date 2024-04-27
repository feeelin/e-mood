using System.Drawing;
using System.Security.Claims;
using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_mood_dotnet.Controller;

[ApiController]
[Route("api/[controller]")]
public class FilesController : ControllerBase
{
    private readonly ILogger<FilesController> _logger;
    private readonly IMusicContext _context;

    public FilesController(
        ILogger<FilesController> logger,
        IMusicContext context)
    {
        _logger = logger;
        _context = context;
    }

    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [HttpPost("UploadFile")]
    public async Task<IActionResult> GetUser()
    {
        var user = await _context.Users.FirstOrDefaultAsync();
        return Ok(user);
    }

    [HttpPost("UploadFile1")]
    public async Task<IActionResult> OnPostUploadAsync(IFormFile files)
    {
        //long size = files.Sum(f => f.Length);

        if (files != null)
        {
            var filePath = Path.GetTempFileName();

            using (var stream = System.IO.File.Create(filePath))
            {
                await files.CopyToAsync(stream);
            }
        }

        // Process uploaded files
        // Don't rely on or trust the FileName property without validation.

        return Ok(new { files }); //count = files.Count, size
    }
}