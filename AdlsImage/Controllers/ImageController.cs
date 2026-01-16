using AdlsImage.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdlsImage.Controllers;

[ApiController]
[Route("api/image")]
public class ImageController : ControllerBase
{
    private readonly BlobService _blobService;

    public ImageController(BlobService blobService)
    {
        _blobService = blobService;
    }

    // Upload image
    [HttpPost("upload")]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No file uploaded");

        var imageUrl = await _blobService.UploadImageAsync(file);
        return Ok(new { imageUrl });
    }

    // Download image
    [HttpGet("download/{fileName}")]
    public async Task<IActionResult> Download(string fileName)
    {
        var stream = await _blobService.DownloadImageAsync(fileName);
        return File(stream, "image/jpeg");
    }
}
