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
    public async Task<IActionResult> OnPostUploadAsync(IFormFile files)
    {
        _logger.LogWarning("got a new file");
        if (files != null)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "storage");
            using (var stream = System.IO.File.Create(filePath))
            {
                await files.CopyToAsync(stream);
            }
        }
        _logger.LogWarning("File {FilesName} uploaded!", files?.Name);
        return Ok(new { files });
    }
}