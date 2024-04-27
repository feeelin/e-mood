using e_mood_dotnet.Context;
using Microsoft.AspNetCore.Mvc;

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

    [HttpPost("UploadFile")]
    public async Task<IActionResult> OnPostUploadAsync(IFormFile files, Guid trackId)
    {
        _logger.LogWarning("got a new file");
        if (files != null)
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "storage", "tracks"));
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "storage", "tracks", $"{trackId}.mp3");
            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                await files.CopyToAsync(stream);
            }
        }
        _logger.LogWarning("File {FilesName} uploaded!", files?.Name);
        return Ok(new { files });
    }

    [HttpGet("GetFile")]
    public async Task<IActionResult> GetFile(Guid id)
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "storage", "tracks", $"{id}.mp3");
        FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        if(stream == null)
            return NotFound();

        return File(stream, "application/octet-stream", $"{id}.mp3"); // returns a FileStreamResult
    }
}